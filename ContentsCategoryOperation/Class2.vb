Imports System.Xml


Public Class Class1

    Public Function XmltoContentsCategoryList(xmlPath As String) As ArrayList

        Dim list As New ArrayList '戻り値用変数


        Dim Document As XmlDocument = New XmlDocument
        Dim Root As XmlElement
        Dim CategoryList As XmlNodeList

        Call XDocument.Load(xmlPath)

        Root = Document.DocumentElement                         'XMLドキュメントからルート要素を取り出す
        CategoryList = Root.GetElementsByTagName("category")    'ルート要素から親リストを取得する

        For Each emt As XmlElement In CategoryList

            Dim cat As New ContentsCategory ' コンテンツカテゴリクラスを宣言

            ' 属性値の値をクラスの変数へ格納
            cat.SetbgColor(emt.SelectSingleNode("@bgColor").Value)
            cat.SetcatId(emt.SelectSingleNode("@catId").Value)
            cat.SetorderLnNo(emt.SelectSingleNode("@orderLnNo").Value)
            cat.SetupCatId(emt.SelectSingleNode("@upperCatId").Value)

            For Each cldemt As XmlElement In emt

            Next cldemt

        Next emt



        XmltoContentsCategoryList = list


    End Function


End Class