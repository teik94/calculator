Module module1


    Sub Main()

        Dim n As Object
        Dim hinh As String
        Dim dat As Date = New Date(2019, 7, 13)

        While True
            Try
                Dim n1 As Short
                n1 = Console.ReadLine()
                Console.WriteLine(n1)
            Catch ex As Exception
                If ex.GetType() = GetType(InvalidCastException) Then
                    Console.WriteLine("Xin hay nhap so")
                End If

                If ex.GetType() = GetType(OverflowException) Then
                    Console.WriteLine("Da xay ra loi tran so")
                End If
            End Try

        End While

        Dim c As New cal2
        Dim nas As Integer = 23
        c.total()
        c.x()

        'While True
        '    Console.WriteLine(" chon phep tinh muoun thuc hien :+ - * /")
        '    Console.WriteLine("1 de tinh chu vi ")
        '    Console.WriteLine("2 de tinh dien tich")

        '    n = Console.ReadLine()
        '    Dim c As New cal
        '    Select Case n
        '        Case "+"
        '            Console.WriteLine("nhap so thu nhat")
        '            c.a = Console.ReadLine()
        '            Console.WriteLine("nhap so thu hai")
        '            c.b = Console.ReadLine()

        '            Console.WriteLine(c.total())
        '            Console.ReadLine()
        '        Case "-"
        '            Console.WriteLine("nhap so thu nhat")
        '            c.a = Console.ReadLine()
        '            Console.WriteLine("nhap so thu hai")
        '            c.b = Console.ReadLine()

        '            Console.WriteLine(c.minus)
        '            Console.ReadLine()
        '        Case "*"
        '            Console.WriteLine("nhap so thu nhat")
        '            c.a = Console.ReadLine()
        '            Console.WriteLine("nhap so thu hai")
        '            c.b = Console.ReadLine()

        '            Console.WriteLine(c.x)
        '            Console.ReadLine()
        '        Case "/"
        '            Console.WriteLine("nhap so thu nhat")
        '            c.a = Console.ReadLine()
        '            Console.WriteLine("nhap so thu hai")
        '            c.b = Console.ReadLine()
        '            Console.WriteLine(c.chia)
        '            Console.ReadLine()
        '        Case Else
        '            Exit While
        '    End Select
        'End While




        'line1:  Console.WriteLine(" chon phep tinh muoun thuc hien :+ - * / hoac")
        '        Console.WriteLine("1 de tinh chu vi ")
        '        Console.WriteLine("2 de tinh dien tich")

        '        n = Console.ReadLine()
        '        Dim c As New Cal
        '        Select Case n
        '            Case "+"
        '                Console.WriteLine("nhap so thu nhat")
        '                c.a = Console.ReadLine()
        '                Console.WriteLine("nhap so thu hai")
        '                c.b = Console.ReadLine()

        '                Console.WriteLine(c.total)
        '                Console.ReadLine()
        '                GoTo line1
        '            Case "-"
        '                Console.WriteLine("nhap so thu nhat")
        '                c.a = Console.ReadLine()
        '                Console.WriteLine("nhap so thu hai")
        '                c.b = Console.ReadLine()

        '                Console.WriteLine(c.minus)
        '                Console.ReadLine()
        '                GoTo line1

        '            Case "*"
        '                Console.WriteLine("nhap so thu nhat")
        '                c.a = Console.ReadLine()
        '                Console.WriteLine("nhap so thu hai")
        '                c.b = Console.ReadLine()

        '                Console.WriteLine(c.x)
        '                Console.ReadLine()
        '                GoTo line1
        '            Case "/"
        '                Console.WriteLine("nhap so thu nhat")
        '                c.a = Console.ReadLine()
        '                Console.WriteLine("nhap so thu hai")
        '                c.b = Console.ReadLine()
        '                Console.WriteLine(c.chia)
        '                Console.ReadLine()
        '                GoTo line1
        '            Case "1"
        '                Console.WriteLine("chon hinh muon tinh chu vi
        '1.tron
        '2.tam giac
        '3. chu nhat")
        '                hinh = Console.ReadLine()
        '                Select Case hinh
        '                    Case "1"
        '                        Console.WriteLine("nhap duong kinh(cm)")
        '                        c.a = Console.ReadLine()
        '                        Console.WriteLine(c.pTron)
        '                        Console.ReadLine()
        '                        GoTo line1
        '                    Case "2"
        '                        Console.WriteLine("nhap chieu dai canh 1(cm)")
        '                        c.a = Console.ReadLine()
        '                        Console.WriteLine("nhap chieu dai canh 2(cm)")
        '                        c.b = Console.ReadLine()
        '                        Console.WriteLine("nhap chieu dai canh 3(cm)")
        '                        c.c = Console.ReadLine()
        '                        Console.WriteLine(c.pTamgiac)
        '                        Console.ReadLine()
        '                        GoTo line1
        '                    Case "3"
        '                        Console.WriteLine("nhap chieu dai(cm) ")
        '                        c.a = Console.ReadLine()
        '                        Console.WriteLine("nhap chieu rong(cm)")
        '                        c.b = Console.ReadLine()

        '                        Console.WriteLine(c.pTamgiac)
        '                        Console.ReadLine()
        '                        GoTo line1
        '                End Select
        '            Case "2"
        '                Console.WriteLine("chon hinh muon tinh chu vi
        '1.tron
        '2.tam giac
        '3. chu nhat")
        '                hinh = Console.ReadLine()
        '                Select Case hinh
        '                    Case "1"
        '                        Console.WriteLine("nhap duong kinh(cm)")
        '                        c.a = Console.ReadLine()
        '                        Console.WriteLine(c.sTron)
        '                        Console.ReadLine()
        '                        GoTo line1
        '                    Case "2"
        '                        Console.WriteLine("nhap chieu cao(cm)")
        '                        c.a = Console.ReadLine()
        '                        Console.WriteLine("nhap chieu dai canh day(cm)")
        '                        c.b = Console.ReadLine()
        '                        Console.WriteLine(c.sTamgiac)
        '                        Console.ReadLine()
        '                        GoTo line1
        '                    Case "3"
        '                        Console.WriteLine("nhap dai(cm)")
        '                        c.a = Console.ReadLine()
        '                        Console.WriteLine("nhap chieu rong(cm)")
        '                        c.b = Console.ReadLine()
        '                        Console.WriteLine(c.x)
        '                        Console.ReadLine()
        '                        GoTo line1
        '                End Select
        '            Case "thoat"
        '                GoTo line2
        '            Case Else
        '                Console.WriteLine("nhap sai roi,moi nhap lai hoac go thoat de thoat")
        '                GoTo line1
        '        End Select
line2: End Sub

End Module
