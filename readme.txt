請用C#撰寫一個程式要求使用者輸入一整行英文句子，請將字串依照英文的標點符號切割開來，如果是數字（包括整數與浮點數），請將加總起來。如果是一般的單字，請將它存入陣列，並符合以下條件：
  單字不重複（大小寫不分）。
  陣列應考量是否存滿的問題（有必要時需要針對陣列做resize）。
  請使用Insertion Sort。

Menu example:
a) Add, b) Output, c)Quit: a
Input a sentence: the UN Security Council has a discuss at 10 a.m. ET.
10 words inserted!
Sum: 10.00

a) Add, b) Output, c)Quit: b
Sum: 10.00

a
at
Council
discuss
ET
has
m
Security
the
UN

a) Add, b) Output, c)Quit:
