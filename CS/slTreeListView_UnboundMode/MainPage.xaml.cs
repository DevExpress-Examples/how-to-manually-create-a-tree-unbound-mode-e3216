using System;
using System.Windows.Controls;
using DevExpress.Xpf.Grid;

namespace slTreeListView_UnboundMode {
    public partial class MainPage : UserControl {
        public MainPage() {
            InitializeComponent();
            BuildTree();
            treeListView1.ExpandAllNodes();
        }

        private void BuildTree() {
            TreeListNode rootNode = CreateRootNode(new ProjectObject() { Title = "Project: Stanton", Executor = "Nicholas Llams" });
            TreeListNode childNode = CreateChildNode(rootNode, new StageObject() { Title = "Information Gathering", Executor = "Ankie Galva" });
            CreateChildNode(childNode, new TaskObject() { Title = "Design", Executor = "Reardon Felton", State = "In progress" });
        }

        private TreeListNode CreateRootNode(object dataObject) {
            TreeListNode rootNode = new TreeListNode(dataObject);
            treeListView1.Nodes.Add(rootNode);
            return rootNode;
        }

        private TreeListNode CreateChildNode(TreeListNode parentNode, object dataObject) {
            TreeListNode childNode = new TreeListNode(dataObject);
            parentNode.Nodes.Add(childNode);
            return childNode;
        }
    }

    public class StageObject {
        public String Title { get; set; }
        public string Executor { get; set; }
    }

    public class ProjectObject {
        public String Title { get; set; }
        public string Executor { get; set; }
    }

    public class TaskObject {
        public String Title { get; set; }
        public string Executor { get; set; }
        public string State { get; set; }
    }
}
