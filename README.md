
# react-native-ez-modal

## Getting started

`$ npm install react-native-ez-modal --save`

### Mostly automatic installation

`$ react-native link react-native-ez-modal`

### Manual installation


#### iOS

1. In XCode, in the project navigator, right click `Libraries` ➜ `Add Files to [your project's name]`
2. Go to `node_modules` ➜ `react-native-ez-modal` and add `RNEzModal.xcodeproj`
3. In XCode, in the project navigator, select your project. Add `libRNEzModal.a` to your project's `Build Phases` ➜ `Link Binary With Libraries`
4. Run your project (`Cmd+R`)<

#### Android

1. Open up `android/app/src/main/java/[...]/MainActivity.java`
  - Add `import com.reactlibrary.RNEzModalPackage;` to the imports at the top of the file
  - Add `new RNEzModalPackage()` to the list returned by the `getPackages()` method
2. Append the following lines to `android/settings.gradle`:
  	```
  	include ':react-native-ez-modal'
  	project(':react-native-ez-modal').projectDir = new File(rootProject.projectDir, 	'../node_modules/react-native-ez-modal/android')
  	```
3. Insert the following lines inside the dependencies block in `android/app/build.gradle`:
  	```
      compile project(':react-native-ez-modal')
  	```

#### Windows
[Read it! :D](https://github.com/ReactWindows/react-native)

1. In Visual Studio add the `RNEzModal.sln` in `node_modules/react-native-ez-modal/windows/RNEzModal.sln` folder to their solution, reference from their app.
2. Open up your `MainPage.cs` app
  - Add `using Ez.Modal.RNEzModal;` to the usings at the top of the file
  - Add `new RNEzModalPackage()` to the `List<IReactPackage>` returned by the `Packages` method


## Usage
```javascript
import EzModal from 'react-native-ez-modal';

// TODO: What to do with the module?
<EzModal> 
	<Text>Ez Modal </Text>
</EzModal>
```
  