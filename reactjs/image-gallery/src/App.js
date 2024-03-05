import { useEffect, useState } from 'react';
import './App.css';
import { ModalWindow } from './components/modal-window/ModalWindow';
import { ImageGallery } from './components/image-gallery/ImageGallery';

function App() {

  const dataSource = "http://188.166.203.164";
  const [jsonData, setJsonData] = useState({});
  const [showModal, setShowModal] = useState(true);

  const getJsonData = async () => {
    const response = await fetch(`${dataSource}/static/test.json`).then(response => response.json());
    response.terms_of_use.paragraphs.sort((a, b) => a.index - b.index);
    return response;
  };

  useEffect(() => {
    getJsonData().then(data => setJsonData(data));
  }, []);

  return (
    <div className="App">
      {showModal && jsonData.terms_of_use
        ? <ModalWindow setShow={setShowModal} paragraphs={jsonData.terms_of_use.paragraphs}/> 
        : <ImageGallery images={jsonData.images} source={dataSource}/>     
      }
    </div>
  );
}

export default App;
