using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROG7312_POE_municipal_services_application.Service_Request_Status
{
    public class BinarySearchTree
    {
        public class TreeNode
        {
            public ReportData Data; 
            public TreeNode Left;  
            public TreeNode Right;  

            public TreeNode(ReportData data)
            {
                Data = data;  
                Left = null;   
                Right = null;  
            }
        }

        private TreeNode root; 

        public BinarySearchTree()
        {
            root = null;
        }

        public void Insert(ReportData data)
        {
            root = InsertRec(root, data);
        }

        private TreeNode InsertRec(TreeNode root, ReportData data)
        {
            if (root == null)
            {
                root = new TreeNode(data);
                return root;
            }

            if (string.Compare(data.RequestID, root.Data.RequestID) < 0)
                root.Left = InsertRec(root.Left, data);
            else if (string.Compare(data.RequestID, root.Data.RequestID) > 0)
                root.Right = InsertRec(root.Right, data);

            return root;
        }

        public ReportData Search(string requestId)
        {
            return SearchRec(root, requestId);
        }

        private ReportData SearchRec(TreeNode root, string requestId)
        {
            if (root == null || root.Data.RequestID == requestId)
                return root?.Data;

            if (string.Compare(requestId, root.Data.RequestID) < 0)
                return SearchRec(root.Left, requestId);

            return SearchRec(root.Right, requestId);
        }

        public List<ReportData> InOrderTraversal()
        {
            var result = new List<ReportData>();
            InOrderRec(root, result);
            return result;
        }

        private void InOrderRec(TreeNode root, List<ReportData> result)
        {
            if (root != null)
            {
                InOrderRec(root.Left, result);
                result.Add(root.Data);
                InOrderRec(root.Right, result);
            }
        }

    }
}
