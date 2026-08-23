# huaji-calculator

huaji calculator

小时候练习写的程序，仅用作留存 —— 现在，它是**真·计算器**了 /滑稽

## 🛜 网页版（新 v2.0 高级版）

单一文件、零依赖、打开即用：**[index.html](index.html)**，或在 **[GitHub Pages](https://yuhaoxuan2016.github.io/huaji-calculator/)** 直接在线玩。

三种模式（像真·计算器）：

| 模式 | 功能 |
| --- | --- |
| **标准** | 四则运算、括号、百分比 `%`、表达式实时显示、历史记录（点击回填） |
| **科学** | `sin/cos/tan/asin/acos/atan`（角度/弧度切换）、`ln/log/log2/exp`、`√`、`x^y`、`x²`、`n!`、`1/x`、`π`、`e`、隐式乘法（`2π`、`5(3+4)`）、一元负号 |
| **程序员** | 64 位整数，DEC/HEX/OCT/BIN 四进制同步显示、`AND/OR/XOR/NOT`、左右移位 `« »`，按键随进制自动禁用 |
| **换算** | 长度/面积/重量/温度/速度/数据/时间 7 大类单位换算，一键交换单位 |

在线地址：
- GitHub Pages：<https://yuhaoxuan2016.github.io/huaji-calculator/>

通用特性：
- **PWA（与刷题宝同款）**：`manifest.webmanifest` + 手写 `sw.js`（离线优先、自动更新），手机/桌面浏览器「安装」后获得独立应用窗口，无网也能用
- 记忆键（MC / MR / M+ / M−），历史与记忆持久化（localStorage）
- 深色 / 浅色主题切换
- 键盘操作（数字 / 运算符 / ^ / ! / % / 括号 / Enter / Backspace / Esc；程序员模式支持 A-F）
- 除零、非法表达式保留童年遗风「你是来搞笑的吧！/滑稽」
- 兔 logo 视觉与 rabbit 系列应用同款，移动端自适应

> 逻辑已通过 30 项自动化测试（表达式优先级/右结合幂/阶乘/角度弧度/进制换算/位运算/除零兜底）。

## 🐇 童年存档（原版）

`rabbit 1.2beta/` —— .NET Framework 4.5.2 控制台计算器（Visual Studio 打开即可运行），
输入两个数，选加减乘除（1/2/3/4），结尾那句「你是来搞笑的吧！/滑稽」是原汁原味。
