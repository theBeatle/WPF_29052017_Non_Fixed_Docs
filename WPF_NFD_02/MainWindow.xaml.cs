using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPF_NFD_02
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private FlowDocument OldDocument { get; set; }
        private Dictionary<int, FlowDocument> MyBook = new Dictionary<int, FlowDocument>();

        public MainWindow()
        {
            InitializeComponent();

           // if (MyBook != null)
           // {
           //     MyBook.Add(0, new FlowDocument());
           // }

            MyBook?.Add(0, new FlowDocument());

           // int? myValue = null;
           // int y = myValue ?? -1;



        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //First part
            Run runFirst = new Run
            {
                Text = "Hello world "
            };

            //Text with bold font
            Bold bold = new Bold();
            Run runBold = new Run
            {
                Text = "dynamicaly generated"
            };
            bold.Inlines.Add(runBold);

            // Second part
            Run runLast = new Run
            {
                Text = " document"
            };

            // Add to paragraph
            Paragraph paragraph = new Paragraph();
            paragraph.Inlines.Add(runFirst);
            paragraph.Inlines.Add(bold);
            paragraph.Inlines.Add(runLast);

            // Create doc and add paragraph


            FlowDocument document = new FlowDocument();
            document.Blocks.Add(paragraph);

            Paragraph p = new Paragraph(new Run("Hello, world!"))
            {
                FontSize = 36
            };
            document.Blocks.Add(p);


            p = new Paragraph(new Run("The ultimate programming greeting!"))
            {
                FontSize = 14,
                FontStyle = FontStyles.Italic,
                TextAlignment = TextAlignment.Left,
                Foreground = Brushes.Gray
            };
            document.Blocks.Add(p);

            OldDocument = docViewer.Document;
            // View doc
            

            BlockUIContainer block = new BlockUIContainer();
            Button btn = new Button
            {
                Name = "myButton",
                Content = "Restore old Document"
            };
            btn.Click += Button_ReturnOld;
            block.Child = btn;
            document.Blocks.Add(block);

            docViewer.Document = document;

            
        }

        private void Button_ReturnOld(object sender, RoutedEventArgs e)
        {
            docViewer.Document = OldDocument;
        }

      
    }

    public class MyClass
    {
        public int MyProperty1 { get; set; }
        public int MyProperty2 { get; set; }

        private int myVar;
        public int MyProperty
        {
            get => myVar;
            set => myVar = value;
        }

        public override string ToString() => $"P1 {MyProperty1} P2 {MyProperty2}";


    }
}
