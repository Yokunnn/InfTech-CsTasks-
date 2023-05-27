using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test
{
    public partial class Form1 : Form
    {
        private readonly Assembly assembly;
        private Type currentClassType = null;
        private object obj;
        public Form1()
        {
            InitializeComponent();
            assembly = Assembly.LoadFrom("../../../lib/UtilLibrary.dll");
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            List<string> classNames = new List<string>();
            Type interfaceType = assembly.GetType("UtilLibrary.Movie");
            foreach (Type type in assembly.GetTypes())
            {
                if (interfaceType.IsAssignableFrom(type) && !type.IsAbstract)
                {
                    classNames.Add(type.FullName);
                }
            }
            foreach (string name in classNames)
            {
                classComboBox.Items.Add(name);
            }
        }

        private void ClassComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            string className = classComboBox.SelectedItem as string;
            currentClassType = assembly.GetType(className);
            methodsComboBox.SelectedIndex = -1;
            methodsComboBox.Items.Clear();
            flowLayoutPanel1.Controls.Clear();
            foreach (MethodInfo methodInfo in currentClassType.GetMethods(BindingFlags.Public | BindingFlags.Instance))
            {
                methodsComboBox.Items.Add(methodInfo.Name);
            }
            obj = Activator.CreateInstance(currentClassType);
            textBox1.Text = "created new instance of current type object";
        }

        private void MethodComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            if (methodsComboBox.SelectedIndex == -1)
                return;
            string methodName = methodsComboBox.SelectedItem as string;
            MethodInfo methodInfo = currentClassType.GetMethod(methodName);
            flowLayoutPanel1.Controls.Clear();
            textBox1.Text = "";
            foreach (ParameterInfo parameterInfo in methodInfo.GetParameters())
            {
                var textBox = new TextBox
                {
                    PlaceholderText = parameterInfo.Name,
                    Width = 190
                };
                flowLayoutPanel1.Controls.Add(textBox);
            }
        }

        private void ExecuteButton_Click(object sender, EventArgs e)
        {
            if (methodsComboBox.SelectedIndex == -1)
                return;
            string methodName = methodsComboBox.SelectedItem as string;
            MethodInfo methodInfo = currentClassType.GetMethod(methodName);
            var paramList = new List<object>();
            int i = 0;
            try
            {
                foreach (ParameterInfo parameterInfo in methodInfo.GetParameters())
                {
                    string value = flowLayoutPanel1.Controls[i++].Text;
                    object param = Convert.ChangeType(value, parameterInfo.ParameterType);
                    paramList.Add(param);
                }
                object res = methodInfo.Invoke(obj, paramList.ToArray());
                if(res?.GetType().ToString()== "System.Collections.Generic.List`1[System.String]")
                {
                    IEnumerable enumerable = res as IEnumerable;
                    foreach(object elem in enumerable)
                    {
                        textBox1.Text += elem.ToString() + '\r' + '\n';
                    }
                }
                else
                {
                    textBox1.Text = res?.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
