using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace MainApp.View
{
    public partial class DepartmentView : UserControl, IDepartmentView
    {
        public DepartmentView()
        {
            InitializeComponent();
            Binding = new BindingSource();
            Load += OnLoad;

        }

        private void OnLoad(object sender, EventArgs eventArgs)
        {
            if(Binding.List == null) return;
            _populateTreeView(Binding.List);
        }

        private void _populateTreeView(IEnumerable rowViews)
        {
            var list = rowViews.Cast<DataRowView>().ToList();
            var rootNodes = list.Where(delegate(DataRowView view)
                                        {
                                            Guid.TryParse(view["ParentDepartmentID"].ToString(), out Guid parentID);
                                            return parentID == Guid.Empty;
                                        });
            foreach (var rootNode in rootNodes)
            {
               var node = _getTreeNode(rootNode, list);
                tvDepartment.Nodes.Add(node);
            }
        }

        private TreeNode _getTreeNode(DataRowView row, IEnumerable<DataRowView> list)
        {
            Guid.TryParse(row["ID"].ToString(), out Guid nodeID);
            var node = new TreeNode
            {
                Text = Convert.ToString(row["Name"])
            };
            var res = list.Where(delegate (DataRowView view)
                                    {
                                        Guid id;
                                        Guid.TryParse(view["ParentDepartmentID"].ToString(), out id);
                                        return id == nodeID;
                                    });
            foreach (var item in res)
            {
                var chNode = _getTreeNode(item, list);
                chNode.Text = Convert.ToString(item["Name"]);
                node.Nodes.Add(chNode);
            }

            return node;
        }

        public BindingSource Binding { get; }
    }
}
