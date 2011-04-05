set DEPLOY_DIR=C:\Program Files\Microsoft Visual Studio 9.0\Common7\ide\ItemTemplatesCache\CSharp

if not exist "%DEPLOY_DIR%" echo "VS Not exist..."

if not exist "%DEPLOY_DIR%" exit.

xcopy Class.cs "%DEPLOY_DIR%\Code\2052\Class.zip" /y /f

xcopy Interface.cs "%DEPLOY_DIR%\Code\2052\Interface.zip" /y /f

xcopy form.cs "%DEPLOY_DIR%\Windows Forms\2052\Form.zip" /y /f
xcopy form.designer.cs "%DEPLOY_DIR%\Windows Forms\2052\Form.zip" /y /f


xcopy usercontrol.cs "%DEPLOY_DIR%\Windows Forms\2052\UserControl.zip" /y /f
xcopy usercontrol.designer.cs "%DEPLOY_DIR%\Windows Forms\2052\UserControl.zip" /y /f

xcopy customcontrol.cs "%DEPLOY_DIR%\Windows Forms\2052\CustomControl.zip" /y /f
xcopy customcontrol.designer.cs "%DEPLOY_DIR%\Windows Forms\2052\CustomControl.zip" /y /f

xcopy AboutBox.cs "%DEPLOY_DIR%\Windows Forms\2052\AboutBox.zip" /y /f
xcopy AboutBox.Designer.cs "%DEPLOY_DIR%\Windows Forms\2052\AboutBox.zip" /y /f

xcopy component.cs "%DEPLOY_DIR%\General\2052\Component.zip" /y /f
xcopy component.designer.cs "%DEPLOY_DIR%\General\2052\Component.zip" /y /f

pause 

