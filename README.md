# 搞定元素周期表，初中化学没烦恼！ `📖帮助文档`

![icon](https://user-images.githubusercontent.com/97453940/151662444-766a6be2-190e-4623-9909-7800469a73c8.png)

>这是一款简单易用的元素周期表助记游戏，欢迎大家下载使用！
>
>喜欢的话可以Star一下，希望这个程序可以帮到更多的人！
>
>若在使用过程中发现什么问题，欢迎提交Issue！

# 视频教程

![image](https://user-images.githubusercontent.com/97453940/153873806-ddcc05d0-3a7c-4ef1-bec2-5f9479159f8d.png)
**微信** `扫码观看视频`

# 文档索引

- [1. 使用说明](#1-使用说明)
- - [1.1 基本操作](#11-基本操作)
- - - [1.1.1 启动](#111-启动)
- - - [1.1.2 认识界面](#112-认识界面)
- - [1.2 游戏规则](#12-游戏规则)
- - - [1.2.1 基本规则](#121-基本规则)
- - - [1.2.2 等级说明](#122-等级说明)
- - - [1.2.3 彩蛋](#123-彩蛋)
- - [1.3 使用技巧](#13-使用技巧)
- - - [1.3.1 功能区](#131-功能区)
- - - [1.3.2 学习视图](#132-学习视图)
- - - [1.3.3 设置测试范围](#133-设置测试范围)
- [2. 设计说明](#2-设计说明)
- - [2.1 设计目的](#21-设计目的)
- - [2.2 开发环境](#22-开发环境)
- - [2.3 核心算法](#23-核心算法)
- - - [2.3.1 元素选择算法](#231-元素选择算法)
- - - [2.3.2 范围纠错算法](#232-范围纠错算法)
- [3. 测试记录](#3-测试记录)

# 1. 使用说明

## 1.1 基本操作

### 1.1.1 启动

![SplashScreen](https://user-images.githubusercontent.com/97453940/153740143-cf13663f-0b3f-4c84-ab21-a2d021e0457d.png)

由于界面按钮较多，加载速度较慢，启动时会弹出上图所示的图片，请您耐心等待。

**[返回索引](#文档索引)**

### 1.1.2 认识界面

![image](https://user-images.githubusercontent.com/97453940/153740348-4a7bd998-03e3-48fe-a7f8-087eed17605c.png)

这是程序界面。上方按钮是[功能区](#131-功能区)，你可以点击对应按钮启动相应功能。具体按钮的功能在[后文](#131-功能区)会予以介绍。

![image](https://user-images.githubusercontent.com/97453940/153740474-93df54d1-bacd-4055-9337-4e0ac2f322d8.png)

功能区下方是等级积分区。积分与等级的换算规则以及不同等级的介绍会在[后文](#122-等级说明)介绍。

![image](https://user-images.githubusercontent.com/97453940/153740573-fba92c48-53c1-4521-b99f-0c8dbe8a4d5a.png)

下方按钮排列成元素周期表形状，上面的文字是每个元素的原子序数。元素周期表的左侧文字代表对应行的周期，上方文字代表对应列的族。

![image](https://user-images.githubusercontent.com/97453940/153740531-0c0283d8-eee1-4ed9-b05e-282095976a25.png)

元素周期表上方空地由3部分构成。左侧是元素提示框，右上方是限时进度条，右下方是[游戏规则](#12-游戏规则)。

![image](https://user-images.githubusercontent.com/97453940/153740602-2fa102d2-30ba-42c8-af13-78baa595678a.png)

**[返回索引](#文档索引)**

## 1.2 游戏规则

### 1.2.1 基本规则

你需要根据元素提示框的显示内容，单击元素周期表上对应位置的方块。答对者有积分奖励。
**为了鼓动大家的学习积极性，我没有设置超时或答错的扣分，这不是BUG！**

![image](https://user-images.githubusercontent.com/97453940/153740769-d038be4d-ac2f-4860-9506-9beddfac54a3.png)

如果你答对了，会得到这样一个弹窗，并获得10积分。

![image](https://user-images.githubusercontent.com/97453940/153740790-8d23812c-81cb-4c1d-9574-22fcc24923ee.png)

如果你答错了，会获得这样一个弹窗，并告诉你正确答案。你的积分不会有任何变化。

![image](https://user-images.githubusercontent.com/97453940/153749594-6e954c77-43ad-4a2a-877b-ec6a7b95ff16.png)

如果你超时未答，会获得这样一个弹窗，并告诉你正确答案。你的积分不会有任何变化。

**点掉弹窗后，游戏会自动继续**

**[返回索引](#文档索引)**

### 1.2.2 等级说明

| 等级 | 称号 | 积分 | 限时 | 备注 |
| :---: | :---: | :---: | :---: | :---:|
| LV0 | 默默无闻 | 0~10 | 30s | - |
| LV1 | 努力向前 | 10~100 | 25s | - |
| LV2 | 小有成就 | 100~1000 | 20s | - |
| LV3 | 聪明绝顶 | 1000~10000 | 15s | - |
| LV4 | 顶级大师 | ≥10000 | 10s | 最高等级，解锁原子量测试 |

如果你的积分达到晋级标准，你会收到类似下图所示的弹窗。

![image](https://user-images.githubusercontent.com/97453940/153741175-69b0f250-8dfa-4078-b59f-0386b9482c2e.png)

**点掉弹窗后，游戏会自动继续**

**[返回索引](#文档索引)**

### 1.2.3 彩蛋

如果你暂时想不出元素所在的位置，你可以右键单击任意按钮查看提示。不必有顾虑，你可以翻开提示无限次，而不用担心自己的积分受到影响（前提是手速足够快）。

![image](https://user-images.githubusercontent.com/97453940/153741276-2e696345-a716-47b5-91e4-596d45d2ef65.png)

**引发弹窗后，游戏不会暂停，请尽快返回答题**

**[返回索引](#文档索引)**

## 1.3 使用技巧

### 1.3.1 功能区

单击 `重置` 按钮，游戏的等级、积分都会清零，测试范围也会恢复默认值，并开始新的游戏。
**不要轻易单击这个按钮！**

单击 `帮助` 按钮，会在默认浏览器中打开帮助页面。

![image](https://user-images.githubusercontent.com/97453940/153757134-04ec55a8-6a1e-4b59-92a5-7c97bee3aad6.png)

单击 `学习` 按钮，会启动[学习视图](#132-学习视图)。具体的用法会在[后文](#132-学习视图)介绍。

![image](https://user-images.githubusercontent.com/97453940/153744914-37c19ab3-98f1-48dd-b808-43a98c5f69f4.png)

单击 `关于` 按钮，会启动关于窗口。

![image](https://user-images.githubusercontent.com/97453940/153745094-abac165c-1280-42e9-ae08-f9184d668d20.png)

单击 `测试范围` 按钮，可以[设置测试范围](#133-设置测试范围)。具体的用法会在[后文](#133-设置测试范围)介绍。

![image](https://user-images.githubusercontent.com/97453940/153749640-85051c1f-e562-4f9e-a5ca-ca755c95ed0a.png)

**所有功能区的按钮点击后均会暂停游戏，请放心点击！如果想要继续游戏，必须关闭所有由功能区打开的窗口。**

**[返回索引](#文档索引)**

### 1.3.2 学习视图

**打开学习视图后，游戏窗口将会隐藏，关闭学习视图或点击 `返回游戏` 按钮后恢复显示。学习视图仅供学习使用，所有行为不计入积分**

![image](https://user-images.githubusercontent.com/97453940/153744914-37c19ab3-98f1-48dd-b808-43a98c5f69f4.png)

你可以将鼠标移到对应的按钮上以显示对应的元素信息。元素信息会被显示在元素周期表上方的空地上。

![image](https://user-images.githubusercontent.com/97453940/153746005-65aaab98-3c04-4dff-8d8b-5586e77d7d56.png)

如果你直接点击某个按钮，将会直接弹窗显示对应的元素信息。

**[返回索引](#文档索引)**

### 1.3.3 设置测试范围

![image](https://user-images.githubusercontent.com/97453940/153749650-0b984488-7450-4d6c-b94f-095d9e40ce84.png)

测试范围的设置格式如下：

`范围或代码` ,  `另一组范围或代码` , `以此类推`

代码指对应元素的原子序数。“镧系”按钮的代码是 `119` ，“锕系”按钮的代码是 `120`

范围的格式如下：

`较小代码` - `较大代码`

**如果多次设置同一个范围或代码，相当于增加相应范围或代码的抽中概率。**

**注意：测试范围设置时不可以包含除数字、逗号、横杠以外的其他字符。一组范围只能包含一个横杠，横杠两端必须有数字，且左边<右边，两边数字必须在1~120的范围以内。单个代码必须是1~120的数字。两个逗号之间必须有内容。如果输入不符合要求，将会收到如下弹窗：**

![image](https://user-images.githubusercontent.com/97453940/153746436-9f7957bc-4e15-4e73-98ee-43f40d9f7415.png)

设置完之后，点击 `提交` 或按下 `ENTER` 可以保存更改。**所有更改在下一局生效。窗口关闭时测试范围会和等级、积分一起保存。**

**[返回索引](#文档索引)**

# 2. 设计说明

## 2.1 设计目的

在初中化学中，元素周期表占据重要地位。但是很多初中生面临着背不下元素周期表的问题。为了解决这一问题，我设计了这个程序，以解决同学们的问题，让同学们在游戏中学会元素周期表。

**[返回索引](#文档索引)**

## 2.2 开发环境

|项目|内容|
|:---:|:---:|
|IDE|Visual Studio Code 2022 Preview (17.1.0 Preview 6.0)|
|编程语言|C#|
|开发框架|.NET 6.0|
|项目类型|WPF应用程序|
|运行环境|Windows 10|

**[返回索引](#文档索引)**

## 2.3 核心算法

### 2.3.1 元素选择算法

算法的流程图如下：

![算法流程图-元素选择算法 (1)](https://user-images.githubusercontent.com/97453940/153753642-3f77cc78-0d75-4ce6-90b5-79767dc03e85.svg)

**为表述方便，流程图有些地方会与实际代码不一致，请以实际代码为准，流程图仅供参考**

详细代码：

```C#
        private void GetNewElement()
        {
            string elementname = "Unknown";
            Random rnd = new();
            List<string> selected = new();
            List<Button> selected_btns = new();
            if (Properties.Settings.Default.Selected.Contains(','))
            {
                foreach (string str in Properties.Settings.Default.Selected.Split(","))
                {
                    selected.Add(str);
                }
            }
            else
            {
                selected.Add(Properties.Settings.Default.Selected);
            }
            foreach (string str in selected)
            {
                if (str.Contains('-'))
                {
                    for (int i = Convert.ToInt32(str.Split("-")[0].ToString()) - 1; i < Convert.ToInt32(str.Split("-")[1].ToString()); i++)
                    {
                        selected_btns.Add(btns[i]);
                    }

                }
                else
                {
                    selected_btns.Add(btns[Convert.ToInt32(str) - 1]);
                }
            }
            if (Properties.Settings.Default.Level == 4) elementname = selected_btns[rnd.Next(selected_btns.Count)].Tag.ToString().Split(",")[rnd.Next(3)];
            else elementname = selected_btns[rnd.Next(selected_btns.Count)].Tag.ToString().Split(",")[rnd.Next(2)];
            
            ElementNameBar.Content = elementname;

        }
```

**[返回索引](#文档索引)**

### 2.3.2 范围纠错算法

算法的流程图如下：

![算法流程图-范围纠错算法](https://user-images.githubusercontent.com/97453940/153852314-9b694e0f-d385-4103-8f81-a1f61946e35b.svg)

**为表述方便，流程图有些地方会与实际代码不一致，请以实际代码为准，流程图仅供参考**

详细代码：

```C#
        private int CountChar(char chr,string str)
        {
            int count=0;
            foreach(char c in str)
            {
                if (c == chr) count++;
            }
            return count;

        }
        private bool Check(string CheckText)
        {
            List<string> list=new();
            try
            {
                if (!string.IsNullOrWhiteSpace(CheckText))
                {
                    if (CheckText.Contains(','))
                    {
                        foreach (string s in CheckText.Split(","))
                        {
                            if ((!String.IsNullOrWhiteSpace(s)) && (CountChar('-', s) == 1|| CountChar('-', s) == 0) &&s[0]!='-') list.Add(s);
                            else return false;

                        }
                    }
                    else if (CheckText.Contains(' ')|| CountChar('-', CheckText) > 1 || CheckText[0] == '-') return false;
                    else list.Add(CheckText);

                    foreach (string s in list)
                    {
                        if ((!s.Contains('-')) && Convert.ToInt32(s) >= 1 && Convert.ToInt32(s) <= 120) return true;
                        else if (s.Contains('-') && s.Split("-").Length == 2 && Convert.ToInt32(s.Split("-")[0]) >= 1 && Convert.ToInt32(s.Split("-")[0]) <= 120 && Convert.ToInt32(s.Split("-")[1]) >= 1 && Convert.ToInt32(s.Split("-")[1]) <= 120&& Convert.ToInt32(s.Split("-")[0])< Convert.ToInt32(s.Split("-")[1])) return true;
                        else return false;
                    }
                    return false;
                }
                else return false;
            }
            catch
            {
                return false;
            }
        }
```

**[返回索引](#文档索引)**

# 3. 测试记录

|序号|测试步骤|预期结果|测试结果|问题记录|测试日期与版本|处理结果|
|:---:|:---:|:---:|:---:|:---:|:---:|:---:|
|1|同时打开多个界面（20个），看多个界面的程序是否正常运行|程序正常运行|✓通过|-|2022.2.2，BugFix20220202|-|
|2|在Windows 7中运行，看是否正常运行|程序正常运行|✗不通过|鼠标双击程序时出现提示“缺少api-ms-win-core-winrt-l1-1-0.dll”|2022.2.2，BugFix20220202|已在v22.2.13中修复：更改发布选项|
|3|在Windows XP中运行，看是否正常运行|程序正常运行|✗不通过|鼠标双击程序时出现提示“不是有效的win32应用程序”|2022.2.2，BugFix20220202|因用户过少，没有修复价值，已放弃修复|
|4|缩放窗口检查响应式布局是否有效|响应式布局有效|✗不通过|缩放时界面出现错乱|2022.2.2，BugFix20220202|已在v22.2.13中修复：修复MainWindow.xaml|
|5|检查倒计时是否正常|倒计时正常|✓通过|-|2022.2.2，BugFix20220202|-|
|6|点击按钮，看答对是否有相应的加分|加分正常|✓通过|-|2022.2.2，BugFix20220202|-|
|7|点击按钮，看答错是否显示答案|提示正常|✓通过|-|2022.2.2，BugFix20220202|-|
|8|不点击按钮，看时间到后是否显答案|提示正常|✓通过|-|2022.2.2，BugFix20220202|-|
|9|检查等级积分体系是否正常|等级积分体系正常|✓通过|-|2022.2.2，BugFix20220202|-|
|10|点击功能区按钮，看能否启动相应功能|功能正常|✓通过|-|2022.2.2，BugFix20220202|-|
|11|打开学习视图，看功能是否正常|功能正常|✓通过|-|2022.2.2，BugFix20220202|-|
|12|在Windows 7中运行，看是否正常运行|程序正常运行|✓通过|-|2022.2.13，v22.2.13|-|
|13|缩放窗口检查响应式布局是否有效|响应式布局有效|✓通过|-|2022.2.13，v22.2.13|-|
|14|检查“选择测试范围”功能是否正常|功能正常|✗不通过|使用横杠选取范围时显示输入无效|2022.2.13，v22.2.13|已通过更新v22.2.13修复：修复校对算法|
|15|检查“帮助”功能是否正常|功能正常|✗不通过|帮助窗口的WebView2控件无法显示|2022.2.13，v22.2.13|已通过更新v22.2.13修复：取消内嵌浏览器，改为用默认浏览器打开链接|
|16|检查“关于”功能是否正常|功能正常|✗不通过|单击链接后，内嵌浏览器的WebView2控件无法显示|2022.2.13，v22.2.13|已通过更新v22.2.13修复：取消内嵌浏览器，改为用默认浏览器打开链接|
|17|检查“选择测试范围”功能是否正常|功能正常|✓通过|-|2022.2.14，v22.2.13|-|
|18|检查“帮助”功能是否正常|功能正常|✓通过|-|2022.2.14，v22.2.13|-|
|19|检查“关于”功能是否正常|功能正常|✓通过|-|2022.2.14，v22.2.13|-|
|20|游戏视图下右键点击按钮，看是否有提示|提示正常|✓通过|-|2022.2.14，v22.2.13|-|

**[返回索引](#文档索引)**
