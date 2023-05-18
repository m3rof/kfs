import 'dart:io';

import 'package:flutter/material.dart';
import 'package:tflite/tflite.dart';
import 'package:image_picker/image_picker.dart';

class Home extends StatefulWidget {
  const Home({Key? key}) : super(key: key);

  @override
  State<Home> createState() => _HomeState();
}

class _HomeState extends State<Home> {
  bool loading = true;
  late File _image;
  late List _output;
  final picker = ImagePicker();

  detectImage(File image) async {
    var output = await Tflite.runModelOnImage(
        path: image.path,
        numResults: 2,
        threshold: .6,
        imageMean: 127.5,
        imageStd: 127.5);
    setState(() {
      _output = output!;
      loading = false;
    });
  }

  loadModel() async {
    await Tflite.loadModel(
        model: 'assets/model_unquant.tflite', labels: 'assets/labels.txt');
  }

  @override
  void initState() {
    // TODO: implement initState
    super.initState();
    loadModel().then((value) {
      setState(() {});
    });
  }

  @override
  void dispose() {
    // TODO: implement dispose
    super.dispose();
  }

  pickImage() async {
    var image = await picker.getImage(source: ImageSource.camera);
    if (image == null) return null;
    setState(() {
      _image = File(image.path);
    });
    detectImage(_image);
  }

  pickGallaryImage() async {
    var image = await picker.getImage(source: ImageSource.gallery);
    if (image == null) return null;
    setState(() {
      _image = File(image.path);
    });
    detectImage(_image);
  }

  @override
  @override
  Widget build(BuildContext context) {
    return Scaffold(
      backgroundColor: Colors.blue,
      body: Container(
        padding: EdgeInsets.symmetric(horizontal: 24),
        child: Column(
          crossAxisAlignment: CrossAxisAlignment.start,
          children: [
            SizedBox(
              height: 50,
            ),
            Text('coding cafe',
                style: TextStyle(color: Colors.white, fontSize: 20)),
            SizedBox(
              height: 5,
            ),
            Text(
              'cats and dogs Dectecor App',
              style: TextStyle(
                  color: Colors.white,
                  fontSize: 30,
                  fontWeight: FontWeight.w500),
            ),
            Center(
                child: loading
                    ? Container(
                        width: 250,
                        child: Column(
                          children: [
                            Image.asset('assets/PngItem_2140759.png'),
                            SizedBox(
                              height: 50,
                            )
                          ],
                        ),
                      )
                    : Container(
                        child: Column(
                          children: [
                            Container(
                              height: 250,
                              child: Image.file(_image),
                            ),
                            SizedBox(
                              height: 20,
                            ),
                            _output != null
                                ? Text(
                                    '${_output[0]['label']}',
                                    style: TextStyle(
                                        color: Colors.white, fontSize: 15),
                                  )
                                : Container(),
                            SizedBox(height: 20,)
                          ],
                        ),
                      )),
            Container(
              width: MediaQuery.of(context).size.width,
              child: Column(
                children: [
                  GestureDetector(
                    onTap: () {
                      pickImage();
                    },
                    child: Container(
                      width: MediaQuery.of(context).size.width - 200,
                      padding:
                          EdgeInsets.symmetric(horizontal: 25, vertical: 18),
                      alignment: Alignment.center,
                      decoration: BoxDecoration(
                          color: Colors.greenAccent,
                          borderRadius: BorderRadius.circular(6)),
                      child: Text('capture a photo',
                          style: TextStyle(color: Colors.white, fontSize: 20)),
                    ),
                  ),
                  SizedBox(height: 15),
                  GestureDetector(
                    onTap: () {
                      pickGallaryImage();
                    },
                    child: Container(
                      width: MediaQuery.of(context).size.width - 200,
                      padding:
                          EdgeInsets.symmetric(horizontal: 25, vertical: 18),
                      alignment: Alignment.center,
                      decoration: BoxDecoration(
                          color: Colors.greenAccent,
                          borderRadius: BorderRadius.circular(6)),
                      child: Text('select a photo',
                          style: TextStyle(color: Colors.white, fontSize: 22)),
                    ),
                  ),
                ],
              ),
            )
          ],
        ),
      ),
    );
  }
}
