# Numeric-Normalization
I have created programs in various languages to normalize numbers.

# 説明
このメソッドは、渡された数値を min から max の間に収めるメソッドになっています。

min = 0, max = 10の場合は以下のような動作になります。

x = 0
return 0

x = 1
return 1
.
.
.
x = 10
return 10

x = 11
return 0
max以上になった場合はminに戻り、maxを2以上超えた場合は、「min+超えた値」となります。

x = 12
return 1

x = 13
return 2

逆の動作も同じで、min以下になった場合はmaxに戻り、minを2以上超えた場合は、「max-超えた値」となります。

x = -1
return 10

x = -2
return 9
