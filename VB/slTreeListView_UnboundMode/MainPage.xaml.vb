Imports Microsoft.VisualBasic
Imports System
Imports System.Windows.Controls
Imports DevExpress.Xpf.Grid

Namespace slTreeListView_UnboundMode
	Partial Public Class MainPage
		Inherits UserControl
		Public Sub New()
			InitializeComponent()
			BuildTree()
			treeListView1.ExpandAllNodes()
		End Sub

		Private Sub BuildTree()
			Dim rootNode As TreeListNode = CreateRootNode(New ProjectObject() With {.Title = "Project: Stanton", .Executor = "Nicholas Llams"})
			Dim childNode As TreeListNode = CreateChildNode(rootNode, New StageObject() With {.Title = "Information Gathering", .Executor = "Ankie Galva"})
			CreateChildNode(childNode, New TaskObject() With {.Title = "Design", .Executor = "Reardon Felton", .State = "In progress"})
		End Sub

		Private Function CreateRootNode(ByVal dataObject As Object) As TreeListNode
			Dim rootNode As New TreeListNode(dataObject)
			treeListView1.Nodes.Add(rootNode)
			Return rootNode
		End Function

		Private Function CreateChildNode(ByVal parentNode As TreeListNode, ByVal dataObject As Object) As TreeListNode
			Dim childNode As New TreeListNode(dataObject)
			parentNode.Nodes.Add(childNode)
			Return childNode
		End Function
	End Class

	Public Class StageObject
		Private privateTitle As String
		Public Property Title() As String
			Get
				Return privateTitle
			End Get
			Set(ByVal value As String)
				privateTitle = value
			End Set
		End Property
		Private privateExecutor As String
		Public Property Executor() As String
			Get
				Return privateExecutor
			End Get
			Set(ByVal value As String)
				privateExecutor = value
			End Set
		End Property
	End Class

	Public Class ProjectObject
		Private privateTitle As String
		Public Property Title() As String
			Get
				Return privateTitle
			End Get
			Set(ByVal value As String)
				privateTitle = value
			End Set
		End Property
		Private privateExecutor As String
		Public Property Executor() As String
			Get
				Return privateExecutor
			End Get
			Set(ByVal value As String)
				privateExecutor = value
			End Set
		End Property
	End Class

	Public Class TaskObject
		Private privateTitle As String
		Public Property Title() As String
			Get
				Return privateTitle
			End Get
			Set(ByVal value As String)
				privateTitle = value
			End Set
		End Property
		Private privateExecutor As String
		Public Property Executor() As String
			Get
				Return privateExecutor
			End Get
			Set(ByVal value As String)
				privateExecutor = value
			End Set
		End Property
		Private privateState As String
		Public Property State() As String
			Get
				Return privateState
			End Get
			Set(ByVal value As String)
				privateState = value
			End Set
		End Property
	End Class
End Namespace
