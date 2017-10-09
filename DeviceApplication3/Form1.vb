Public Class Form1
    Inherits System.Windows.Forms.Form
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents MenuItem1 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem2 As System.Windows.Forms.MenuItem
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox5 As System.Windows.Forms.PictureBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents MenuItem3 As System.Windows.Forms.MenuItem
    Friend WithEvents MainMenu1 As System.Windows.Forms.MainMenu

#Region " Windows フォーム デザイナで生成されたコード "

    Public Sub New()
        MyBase.New()

        'この呼び出しは、Windows フォーム デザイナで必要です。
        InitializeComponent()

        'InitializeComponent() 呼び出しの後で初期化を追加します

    End Sub

    'フォームがコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        MyBase.Dispose(disposing)
    End Sub

    'メモ: 以下のプロシージャは Windows フォーム デザイナで必要です。
    'Windows フォーム デザイナを使用して変更できます。  
    'コード エディタを使って変更しないでください。
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.MainMenu1 = New System.Windows.Forms.MainMenu
        Me.MenuItem1 = New System.Windows.Forms.MenuItem
        Me.MenuItem2 = New System.Windows.Forms.MenuItem
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Timer1 = New System.Windows.Forms.Timer
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.PictureBox3 = New System.Windows.Forms.PictureBox
        Me.PictureBox4 = New System.Windows.Forms.PictureBox
        Me.PictureBox5 = New System.Windows.Forms.PictureBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.MenuItem3 = New System.Windows.Forms.MenuItem
        '
        'MainMenu1
        '
        Me.MainMenu1.MenuItems.Add(Me.MenuItem1)
        '
        'MenuItem1
        '
        Me.MenuItem1.MenuItems.Add(Me.MenuItem3)
        Me.MenuItem1.MenuItems.Add(Me.MenuItem2)
        Me.MenuItem1.Text = "Misc(&M)"
        '
        'MenuItem2
        '
        Me.MenuItem2.Text = "終了(&E)"
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(3, 3)
        Me.PictureBox1.Size = New System.Drawing.Size(237, 207)
        '
        'Timer1
        '
        Me.Timer1.Interval = 50
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(292, 147)
        Me.PictureBox2.Size = New System.Drawing.Size(18, 41)
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Red
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Regular)
        Me.Label2.ForeColor = System.Drawing.Color.Gold
        Me.Label2.Location = New System.Drawing.Point(25, 24)
        Me.Label2.Size = New System.Drawing.Size(136, 33)
        Me.Label2.Text = "GAME OVER !!!"
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(255, 123)
        Me.PictureBox3.Size = New System.Drawing.Size(39, 17)
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(305, 123)
        Me.PictureBox4.Size = New System.Drawing.Size(48, 18)
        '
        'PictureBox5
        '
        Me.PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), System.Drawing.Image)
        Me.PictureBox5.Location = New System.Drawing.Point(271, 66)
        Me.PictureBox5.Size = New System.Drawing.Size(58, 51)
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(35, 74)
        Me.Button1.Size = New System.Drawing.Size(154, 79)
        Me.Button1.Text = "Click to start game..."
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Silver
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(175, 121)
        Me.Label1.Size = New System.Drawing.Size(53, 24)
        Me.Label1.Text = "Label1"
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Silver
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(175, 145)
        Me.Label3.Size = New System.Drawing.Size(53, 20)
        Me.Label3.Text = "Label3"
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Silver
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(176, 168)
        Me.Label4.Size = New System.Drawing.Size(52, 23)
        Me.Label4.Text = "Label4"
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Silver
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(176, 187)
        Me.Label5.Size = New System.Drawing.Size(52, 22)
        Me.Label5.Text = "Label5"
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Red
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 11.0!, System.Drawing.FontStyle.Regular)
        Me.Label6.ForeColor = System.Drawing.Color.Gold
        Me.Label6.Location = New System.Drawing.Point(40, 50)
        Me.Label6.Size = New System.Drawing.Size(121, 19)
        Me.Label6.Text = "Label6"
        '
        'MenuItem3
        '
        Me.MenuItem3.Text = "About(&A)"
        '
        'Form1
        '
        Me.ClientSize = New System.Drawing.Size(345, 213)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.PictureBox5)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Menu = Me.MainMenu1
        Me.Text = "てとりす"

    End Sub

#End Region

    '変数(ゲーム制御用)
    Dim g As Graphics   'グラフィックス
    Dim gameOver As Object  'ゲームオーバーかどうか(True, False)
    Dim nextBlock As Object '次のブロック
    Dim score As Object 'スコア記憶用
    Dim lines As Object 'ライン数記憶用
    Dim speed() As Object = {1, 2, 3, 4, 6, 8, 16}  'ブロックの落ちるスピード一覧
    Dim keyUe As Object '上が押されているかどうか(True,False)
    Dim keyShita As Object  '下が押されているかどうか(True,False)
    Dim keyHidari As Object '左が押されているかどうか(True,False)
    Dim keyMigi As Object   '右が押されているかどうか(True,False)

    '変数(テトリス画面管理用)
    Dim tet(20, 10) As Object   'テトリス画面
    Dim tetCountX As Object 'テトリス画面カウント用(X方向)
    Dim tetCountY As Object 'テトリス画面カウント用(Y方向)
    Dim kesuCountX As Object    'ライン消しカウント用(X方向)
    Dim kesuCountY As Object    'ライン消しカウント用(Y方向)
    Dim blockColor As Object  'ブロック色計算用
    Dim nowBlock As Object  '現在のブロック
    Dim nowKaiten As Object '現在のブロックの回転回数(右へ0～3回)
    Dim nowX As Object  '現在のブロックのX座標(マス単位)
    Dim nowY As Object  '現在のブロックのY座標(マス単位)
    Dim nowRakka As Object  '現在のブロックのY座標における落下量(ピクセル単位;0～15)
    Dim nowSpeed As Object  '現在のブロックの落下速度(0～6)
    Dim nowTime As Object   '硬直までの残り時間(落下中は-1)
    Dim nowLines As Object  '現在のブロックを落下させた際に揃ったライン数
    Dim sorotta As Object   'ラインが揃ったかどうか記憶するための変数
    '    Dim Gothic As Font
    '変数(ブロック作成用)
    '
    '＜番号とブロックの色の対応は以下のとおり＞
    '    0 = (ブロックが無い部分)
    '    1 = 青
    '    2 = 赤
    '    3 = 紫
    '    4 = 緑
    '    5 = 水色
    '    6 = 黄
    '    7 = 白
    '
    '＜各ブロック毎に，既に回転したものを，すべて用意する＞
    '    |回転系 1|  |回転系 2|  |回転系 3|  |回転系 4|
    '    | 未回転 |  | 右に1回|  | 右に2回|  | 右に3回|
    Dim block(,) As Object = { _
        {0, 0, 1, 1, 0, 0, 1, 0, 0, 0, 0, 0, 0, 1, 0, 0}, _
        {0, 1, 1, 0, 0, 0, 1, 1, 0, 0, 1, 1, 0, 1, 1, 0}, _
        {0, 0, 0, 0, 0, 0, 0, 1, 0, 1, 1, 0, 0, 0, 1, 0}, _
        {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0}, _
 _
        {0, 2, 2, 0, 0, 0, 0, 2, 0, 0, 0, 0, 0, 0, 2, 0}, _
        {0, 0, 2, 2, 0, 0, 2, 2, 0, 2, 2, 0, 0, 2, 2, 0}, _
        {0, 0, 0, 0, 0, 0, 2, 0, 0, 0, 2, 2, 0, 2, 0, 0}, _
        {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0}, _
 _
        {0, 0, 0, 3, 0, 0, 3, 0, 0, 0, 0, 0, 0, 3, 3, 0}, _
        {0, 3, 3, 3, 0, 0, 3, 0, 0, 3, 3, 3, 0, 0, 3, 0}, _
        {0, 0, 0, 0, 0, 0, 3, 3, 0, 3, 0, 0, 0, 0, 3, 0}, _
        {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0}, _
 _
        {0, 4, 0, 0, 0, 0, 4, 4, 0, 0, 0, 0, 0, 0, 4, 0}, _
        {0, 4, 4, 4, 0, 0, 4, 0, 0, 4, 4, 4, 0, 0, 4, 0}, _
        {0, 0, 0, 0, 0, 0, 4, 0, 0, 0, 0, 4, 0, 4, 4, 0}, _
        {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0}, _
 _
        {0, 0, 5, 0, 0, 0, 5, 0, 0, 0, 0, 0, 0, 0, 5, 0}, _
        {0, 5, 5, 5, 0, 0, 5, 5, 0, 5, 5, 5, 0, 5, 5, 0}, _
        {0, 0, 0, 0, 0, 0, 5, 0, 0, 0, 5, 0, 0, 0, 5, 0}, _
        {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0}, _
 _
        {0, 6, 6, 0, 0, 6, 6, 0, 0, 6, 6, 0, 0, 6, 6, 0}, _
        {0, 6, 6, 0, 0, 6, 6, 0, 0, 6, 6, 0, 0, 6, 6, 0}, _
        {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0}, _
        {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0}, _
 _
        {0, 0, 7, 0, 0, 0, 0, 0, 0, 7, 0, 0, 0, 0, 0, 0}, _
        {0, 0, 7, 0, 0, 0, 0, 0, 0, 7, 0, 0, 7, 7, 7, 7}, _
        {0, 0, 7, 0, 7, 7, 7, 7, 0, 7, 0, 0, 0, 0, 0, 0}, _
        {0, 0, 7, 0, 0, 0, 0, 0, 0, 7, 0, 0, 0, 0, 0, 0}, _
 _
        {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0} _
    }
    '    |回転系 1|  |回転系 2|  |回転系 3|  |回転系 4|
    '    | 未回転 |  | 右に1回|  | 右に2回|  | 右に3回|
    ' (最後の1行はブロック追加用のダミー)

    ' Private Sub Form1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
    Private Sub Form1_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        '   If e.KeyCode = Keys.Up Then
        If (e.KeyCode = System.Windows.Forms.Keys.Up) Then
            keyUe = True    '上が押され始めた(左キーをON)
        End If
        '        If e.KeyCode = Keys.Down Then
        If (e.KeyCode = System.Windows.Forms.Keys.Down) Then
            keyShita = True '下が押され始めた(右キーをON)
        End If
        '        If e.KeyCode = Keys.Left Then
        If (e.KeyCode = System.Windows.Forms.Keys.Left) Then
            keyHidari = True    '左が押され始めた(左キーをON)
        End If
        '        If e.KeyCode = Keys.Right Then
        If (e.KeyCode = System.Windows.Forms.Keys.Right) Then
            keyMigi = True  '右が押され始めた(右キーをON)
        End If
    End Sub
    '    Private Sub Form1_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyUp
    Private Sub Form1_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyUp
        If (e.KeyCode = System.Windows.Forms.Keys.Down) Then
            keyShita = False    '下が離された(右キーをOFF)
        End If
    End Sub
    'ブロックの色番号から，実際の色を求めるサブルーチン
    '書式：IroSyutoku(色番号)
    '(求めた色をそのまま呼び出した側に返す，「Function」という特殊なサブルーチン)
    Private Function IroSyutoku(ByVal ColorNo As Object) As Object
        'ブロックの色番号から，実際の色を求める
        blockColor = &HFF000000
        If ColorNo And 4 Then
            blockColor = blockColor Or &HFF00
        End If
        If ColorNo And 2 Then
            blockColor = blockColor Or &HFF0000
        End If
        If ColorNo And 1 Then
            blockColor = blockColor Or &HFF
        End If

        '求めた色を，明るめ(パステル調)にする
        blockColor = blockColor Or &HFF

        '求めた色を，呼び出した側に返す
        Return Color.FromArgb(blockColor)
    End Function

    '指定された番号のブロックを画面上に表示するサブルーチン
    '書式：DrawBlock(ブロック番号, 右に回転させた回数, 左上X座標, 右上X座標)
    '「右に回転させた回数」は，配列変数blockのところで指定されている0～3の数字を指定する．
    Private Sub DrawBlock(ByVal BlockNo As Object, ByVal Kaiten As Object, ByVal x As Object, ByVal y As Object)
        For tetCountY = 0 To 3
            For tetCountX = 0 To 3
                If block(BlockNo * 4 + tetCountY, Kaiten * 4 + tetCountX) <> 0 Then
                    g.FillRectangle(New SolidBrush(IroSyutoku(block(BlockNo * 4 + tetCountY, Kaiten * 4 + tetCountX))), _
                        tetCountX * 16 + x + 1, tetCountY * 16 + y + 1, 14, 14)
                End If
            Next
        Next
    End Sub

    '現在落下中のブロックの衝突判定を行うサブルーチン(衝突していればTrue，そうでなければFalseを返す)
    '(判定結果をそのまま呼び出した側に返す，「Function」という特殊なサブルーチン)
    Private Function ShototsuHantei() As Object
        For tetCountY = 0 To 3
            For tetCountX = 0 To 3
                If block(nowBlock * 4 + tetCountY, nowKaiten * 4 + tetCountX) = 0 Then
                    '    Continue For    'ブロックの無い部分は無視する。ただしPocketPC2003用にContinueステートメントは使えない
                    'のでGoto でExitforラインに飛ぶことにより済ます
                    GoTo Exitfor
                End If
                If nowX + tetCountX < 0 Or nowX + tetCountX > 9 Or nowY + tetCountY < 0 Or nowY + tetCountY > 12 Then
                    'If nowX + tetCountX < 0 Or nowX + tetCountX > 9 Or 2 * nowY + tetCountY < 0 Or 2 * nowY + tetCountY > 19 Then
                    Return True 'ブロックが画面の外にはみ出すので，Trueを返す
                End If
                If tet(nowY + tetCountY, nowX + tetCountX) <> 0 Then                    'If tet(2 * nowY + tetCountY, nowX + tetCountX) <> 0 Then
                    Return True '既に画面上にあるブロックと衝突するので，Trueを返す
                End If
Exitfor:
            Next
        Next
        Return False    '衝突していないことが分かったので，Falseを返す
    End Function

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        'ゲームオーバー状態にあれば，何も処理しない
        If gameOver = True Then
            Exit Sub
        End If
        '画面を黒でクリアする
        g.Clear(Color.FromArgb(0, 0, 0))

        '現在のブロックが無い場合，次のブロックを持ってくる
        If nowBlock = -1 Then
            '次のブロックを作成
            nowBlock = nextBlock
            nowKaiten = 0   '回転していない状態にする
            nowX = 2    'ブロックのX座標はゲーム画面の中心に
            nowY = 0    'ブロックのY座標は一番上に
            nowRakka = 15   '現在のY座標における落下位置は最大に
            nowTime = -1    '硬直までの残り時間は設定されていない状態に
            nextBlock = CInt(Math.Floor(Rnd() * Math.Floor(block.Length / 64)))
            'ブロックを出した時点で衝突していたら，ゲームオーバー
            If ShototsuHantei() = True Then
                gameOver = True
            End If
        End If

        '各種キー入力の受付(自機が生きているときのみ)
        If keyUe = True Then
            nowKaiten = nowKaiten + 1   '「上」が押されたので，右回転を行う
            If nowKaiten > 3 Then
                nowKaiten = 0   '一番右までいったら，回転していない状態に戻す
            End If
            If ShototsuHantei() = True Then
                nowKaiten = nowKaiten - 1 '衝突しているので，回転をキャンセル
                If nowKaiten < 0 Then
                    nowKaiten = 3
                End If
            End If
            keyUe = False   'キーを押されていない状態に戻す
        End If
        If keyShita = True Then
            nowRakka = 15   '一気に落下させる
            score = score + 1   'スコアボーナスを加算する
            If nowTime <> -1 Then
                nowTime = 0 '硬直カウント中の場合は，すぐに硬直させる
            End If
        End If
        If keyHidari = True Then
            nowX = nowX - 1 '「左」が押されたので，ブロックを左に移動
            If ShototsuHantei() = True Then
                nowX = nowX + 1 '衝突しているので，左移動をキャンセル
            End If
            keyHidari = False   'キーを押されていない状態に戻す
        End If
        If keyMigi = True Then
            nowX = nowX + 1 '「右」が押されたので，ブロックを右に移動
            If ShototsuHantei() = True Then
                nowX = nowX - 1 '衝突しているので，右移動をキャンセル
            End If
            keyMigi = False 'キーを押されていない状態に戻す
        End If

        'ブロックの落下スピードの算出
        nowSpeed = CInt(Math.Floor(score / 2500))   '落下速度は2500点ごとに1段階アップ
        If nowSpeed > 6 Then
            nowSpeed = 6    'スピードは6よりも早くならない
        End If

        'ブロックの落下
        nowRakka = nowRakka + speed(nowSpeed)
        If nowRakka > 15 Then
            nowY = nowY + 1 '衝突判定のため，一時的に1マス落下させる
            If ShototsuHantei() = False Then
                nowY = nowY + 1 '1マス落下
                nowRakka = 0    '現在のY位置における落下位置はゼロに
                nowTime = -1    '硬直までの残り時間は設定されていない状態に
            Else
                nowRakka = 15   '衝突するようであれば，これ以上落下させない
                If nowTime = -1 Then
                    nowTime = 10    '硬直までの残り時間が設定されていなければ，設定する
                End If
            End If
            nowY = nowY - 1 '一時的な落下を解除
        End If

        'ブロックの硬直(硬直カウント中のみ)
        If nowTime <> -1 Then
            nowTime = nowTime - 1   '硬直時間のカウント
            If nowTime < 0 Then
                nowTime = -1    '硬直時間終了
                '現在落下中のブロックを，ゲーム画面内に移す
                For tetCountY = 0 To 3
                    For tetCountX = 0 To 3
                        If block(nowBlock * 4 + tetCountY, nowKaiten * 4 + tetCountX) <> 0 Then
                            tet(nowY + tetCountY, nowX + tetCountX) = _
                                block(nowBlock * 4 + tetCountY, nowKaiten * 4 + tetCountX)
                        End If
                    Next
                Next
                nowBlock = -1   '現在のブロックが無い状態に
            End If
        End If

        '揃ったラインを削除する
        nowLines = 0    'まだ何も揃っていない状態に
        For tetCountY = 0 To 19
            '現在のライン中に，空白の部分がないかどうかをチェック
            sorotta = True  'とりあえず現在チェック中のラインは揃ったことにしておく
            For tetCountX = 0 To 9
                If tet(tetCountY, tetCountX) = 0 Then
                    sorotta = False 'ブロックが無いところが見つかったので，揃っていない状態に
                End If
            Next

            '揃ったかどうかをチェック
            If sorotta = True Then
                'ライン数を増やす
                nowLines = nowLines + 1 '揃ったライン数に1を加える
                g.FillRectangle(New SolidBrush(Color.FromArgb(255, 255, 255)), 0, tetCountY * 16, 160, 16)    '揃ったラインを光らせる

                '揃ったラインから上のブロックをすべて下に移動させる
                For kesuCountY = tetCountY To 1 Step -1
                    For kesuCountX = 0 To 9
                        tet(kesuCountY, kesuCountX) = tet(kesuCountY - 1, kesuCountX)   '上のラインから下のラインへコピー
                    Next
                Next

                '最上部のラインを空にする
                For kesuCountX = 0 To 9
                    tet(0, kesuCountX) = 0
                Next
            End If
        Next

        '揃ったライン数に応じて，ライン数およびスコアを加算する
        lines = lines + nowLines
        If nowLines = 1 Then
            score = score + 100 '1ライン揃ったときの得点
        End If
        If nowLines = 2 Then
            score = score + 400 '2ライン揃ったときの得点
        End If
        If nowLines = 3 Then
            score = score + 900 '3ライン揃ったときの得点
        End If
        If nowLines = 4 Then
            score = score + 1600 '4ライン揃ったときの得点
        End If

        '確定しているブロックの描画
        For tetCountY = 0 To 19
            For tetCountX = 0 To 9
                'ブロックを描く
                If tet(tetCountY, tetCountX) <> 0 Then
                    g.FillRectangle(New SolidBrush(IroSyutoku(tet(tetCountY, tetCountX))), _
                        tetCountX * 16 + 1, tetCountY * 16 + 1, 14, 14)
                End If
            Next
        Next

        '落下中のブロックの描画(ある場合のみ)
        If nowBlock <> -1 Then
            DrawBlock(nowBlock, nowKaiten, nowX * 16, nowY * 16 - 15 + nowRakka)
        End If

        '次のブロック，スコア，ライン数の描画
        g.FillRectangle(New SolidBrush(Color.FromArgb(64, 64, 64)), 160, 0, 80, 320)    '全体の長方形
        '       g.DrawString("NEXT", New Font("ＭＳ ゴシック", 15), New SolidBrush(Color.FromArgb(255, 255, 255)), 160, 10)
        g.FillRectangle(New SolidBrush(Color.FromArgb(0, 0, 0)), 168, 32, 64, 64)   'ブロック表示欄の正方形
        DrawBlock(nextBlock, 0, 168, 32)    '次のブロックを描く(サブルーチンを利用)
        Label1.Text = "SCORE"
        '       g.DrawString("SCORE", New Font("ＭＳ ゴシック", 15), New SolidBrush(Color.FromArgb(255, 255, 255)), 160, 240)
        Label3.Text = score
        '      g.DrawString(score, New Font("ＭＳ ゴシック", 15), New SolidBrush(Color.FromArgb(255, 255, 255)), 160, 260)
        Label4.Text = "LINES"
        '     g.DrawString("LINES", New Font("ＭＳ ゴシック", 15), New SolidBrush(Color.FromArgb(255, 255, 255)), 160, 280)
        Label5.Text = lines
        '    g.DrawString(lines, New Font("ＭＳ ゴシック", 15), New SolidBrush(Color.FromArgb(255, 255, 255)), 160, 300)

        '硬直までの時間を描画
        If nowTime <> -1 Then
            '            g.DrawString("硬直まで" & vbNewLine & "残り " & nowTime & vbNewLine & "カウント", _
            '             New Font("ＭＳ ゴシック", 12), New SolidBrush(Color.FromArgb(255, 255, 0)), 168, 112)
        End If
        'ゲームオーバーになったら，その旨を描画する
        If gameOver = True Then
            g.FillRectangle(New SolidBrush(Color.FromArgb(255, 0, 0)), 0, 0, 160, 320)   'ゲーム画面を真っ赤に染める
            '        g.DrawString("ゲームオーバー！", New Font("ＭＳ ゴシック", 24), New SolidBrush(Color.FromArgb(255, 255, 0)), 0, 176)
            Button1.Visible = True
            Label6.Visible = True
            Timer1.Enabled = False
            keyShita = False
            Label2.Visible = True
            Me.Button1.Text = "Click to retry game"
            Me.Label6.Text = "Score: " & score
            PictureBox2.Visible = False
            PictureBox3.Visible = False
            PictureBox4.Visible = False
            PictureBox5.Visible = False
            'PictureBox1.Visible = False
            Label1.Visible = False
            Label3.Visible = False
            Label4.Visible = False
            Label5.Visible = False
        End If
        '画面を確定する
        PictureBox1.Invalidate()
    End Sub
    Private Sub PictureBox2_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox2.MouseDown
        keyShita = True '下が押され始めた(右キーをON)
    End Sub

    Private Sub PictureBox2_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox2.MouseUp
        keyShita = False
        Me.Focus()
    End Sub

    Private Sub MenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem2.Click
        Me.Close()
    End Sub
    Private Sub PictureBox3_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox3.MouseDown
        keyHidari = True    '左が押され始めた(左キーをON)
    End Sub
    Private Sub PictureBox4_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox4.MouseDown
        keyMigi = True  '右が押され始めた(右キーをON)
    End Sub
    Private Sub PictureBox5_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox5.MouseDown
        keyUe = True    '上が押され始めた(左キーをON)
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        'ピクチャーボックスに対して新しいゲーム画面を作成する
        Label2.Visible = False
        Label6.Visible = False
        Label1.Visible = True
        Label3.Visible = True
        Label4.Visible = True
        Label5.Visible = True
        PictureBox2.Visible = True
        PictureBox3.Visible = True
        PictureBox4.Visible = True
        PictureBox5.Visible = True
        PictureBox1.Visible = True
        PictureBox1.Image = New Bitmap(PictureBox1.Width, PictureBox1.Height)

        'グラフィックスを取得する
        g = Graphics.FromImage(PictureBox1.Image)

        '乱数の初期化
        Randomize()

        'スコアとライン数を0点に初期化
        score = 0
        lines = 0

        'テトリス画面の初期化
        For tetCountY = 0 To 19
            For tetCountX = 0 To 9
                tet(tetCountY, tetCountX) = 0   'ブロックが「無い」状態に
            Next
        Next

        'ゲームオーバーでない状態にしておく
        gameOver = False

        '現在のブロックを「無し」の状態にしておく
        nowBlock = -1

        '最初に出るブロックの番号を指定しておく
        nextBlock = 0
        Button1.Visible = False
        Timer1.Enabled = True
        Me.Focus()
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Label2.Visible = False
        PictureBox2.Visible = False
        PictureBox3.Visible = False
        PictureBox4.Visible = False
        PictureBox5.Visible = False
        PictureBox1.Visible = False
        Label1.Visible = False
        Label3.Visible = False
        Label4.Visible = False
        Label5.Visible = False
        Label6.Visible = False
    End Sub

    Private Sub MenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem3.Click
        MsgBox("作成:秋元　真一" & Chr(10) & "参考URL http://www.teu.ac.jp/chiit/~jsuzuki/doc/ ")
    End Sub
End Class
