using Syncfusion.XForms.TreeView;

using Xamarin.Forms;

namespace GettingStartedBound.Behavior
{
    public class TreeViewExpandedBehavior : Behavior<SfTreeView>
    {
        protected override void OnAttachedTo(SfTreeView bindable)
        {
            base.OnAttachedTo(bindable);

            bindable.ItemTapped += Bindable_ItemTapped;
            bindable.QueryNodeSize += Bindable_QueryNodeSize;
        }

        private void Bindable_QueryNodeSize(object sender, QueryNodeSizeEventArgs e)
        {
            e.Height = e.GetActualNodeHeight();
            e.Handled = true;
        }

        private void Bindable_ItemTapped(object sender, Syncfusion.XForms.TreeView.ItemTappedEventArgs e)
        {
            var treeViewNode = e.Node;

            if (treeViewNode.ChildNodes.Count == 0) return;

            var treeView = sender as SfTreeView;

            if (treeViewNode.IsExpanded)
                treeView.CollapseNode(treeViewNode);
            else
                treeView.ExpandNode(treeViewNode);
        }

        protected override void OnDetachingFrom(SfTreeView bindable)
        {
            bindable.ItemTapped -= Bindable_ItemTapped;
            bindable.QueryNodeSize -= Bindable_QueryNodeSize;

            base.OnDetachingFrom(bindable);
        }
    }
}
