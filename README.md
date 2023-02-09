# KeePass 插件汉化
## 简介

虽然插件用久了都明白是啥意思，但是还是中文看着舒服，所以决定将自己在使用的插件进行汉化。

不会 C#，翻译全靠机翻+人工润色。

## 使用说明

在各插件目录下下载汉化后的插件文件，然后手动进行安装。[安装说明-官网](https://keepass.info/help/v2/plugins.html)

### 自己编译

1. 在项目根目录创建名为 KeePass 的目录。
2. 前往 [KeePass]([Downloads - KeePass](https://keepass.info/download.html)) 官网下载最新的绿色版（便携版 KeePass-*.zip），并将压缩包内的所有文件解压至该目录。
3. 进入对应的插件目录，并运行 `build.bat` 批处理文件。
4. 即可在插件目录下生成 `插件名字.plgx` 文件。
