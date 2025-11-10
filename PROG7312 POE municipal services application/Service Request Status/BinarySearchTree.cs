using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Lee James
//ST10311687

namespace PROG7312_POE_municipal_services_application.Service_Request_Status
{
    public class BinarySearchTree
    {
        /// <summary>
        /// Represents a node in the binary search tree.
        /// </summary>
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

        /// <summary>
        /// Initializes a new instance of the BinarySearchTree class.
        /// </summary>
        
        public BinarySearchTree()
        {
            root = null;
        }

        /// <summary>
        /// Inserts a new ReportData into the BST.
        /// </summary>

        public void Insert(ReportData data)
        {
            root = InsertRec(root, data);
        }

        /// <summary>
        /// Helper method for inserting a new ReportData into the BST recursively.
        /// </summary>

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

        /// <summary>
        /// Searches for a ReportData by RequestID.
        /// </summary>

        public ReportData Search(string requestId)
        {
            return SearchRec(root, requestId);
        }

        /// <summary>
        /// Helper method for searching a ReportData by RequestID recursively.
        /// </summary>

        private ReportData SearchRec(TreeNode root, string requestId)
        {
            if (root == null || root.Data.RequestID == requestId)
                return root?.Data;

            if (string.Compare(requestId, root.Data.RequestID) < 0)
                return SearchRec(root.Left, requestId);

            return SearchRec(root.Right, requestId);
        }

        /// <summary>
        /// Performs an in-order traversal of the BST and returns a list of ReportData in sorted order by RequestID.
        /// </summary>
        /// <returns></returns>

        public List<ReportData> InOrderTraversal()
        {
            var result = new List<ReportData>();
            InOrderRec(root, result);
            return result;
        }

        /// <summary>
        /// Helper method for in-order traversal of the BST recursively.
        /// </summary>


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

//________________________________________________________End of File___________________________________________________________________________________