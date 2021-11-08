using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using ZXing;

public class QRScanerScript : MonoBehaviour
{
    [SerializeField] private RawImage _rawImage;
    [SerializeField] private AspectRatioFitter _aspectRatioFitter;
    [SerializeField] private TextMeshProUGUI _textOut;
    [SerializeField] private RectTransform _scanZone;

    private bool _isCamAvaliable;
    private WebCamTexture _camTexture;

    // Start is called before the first frame update
    void Start()
    {
        SetupCamera();
    }

    // Update is called once per frame
    void Update()
    {
        UpdateCameraRender();
    }

    private void SetupCamera()
    {
        WebCamDevice[] camDevices = WebCamTexture.devices;

        if (camDevices.Length == 0)
        {
            _isCamAvaliable = false;
            _textOut.text = "No cameras";
            return;
        }

        for (int i = 0; i < camDevices.Length; i++)
        {
            if (!camDevices[i].isFrontFacing)
            {
                _camTexture = new WebCamTexture(camDevices[i].name, (int)_scanZone.rect.width, (int)_scanZone.rect.height);
                _textOut.text = _scanZone.rect.width.ToString();
            }
        }

        _camTexture.Play();
        _rawImage.texture = _camTexture;
        _isCamAvaliable = true;
    }

    private IEnumerator Scan()
    {
        yield return new WaitForEndOfFrame();
        try
        {
            IBarcodeReader QRCadeReader = new BarcodeReader();
            Result res = QRCadeReader.Decode(_camTexture.GetPixels32(), _camTexture.width, _camTexture.height);
            if (res != null)
            {
                _textOut.text = res.Text;
            }
            else
            {
                _textOut.text = "Failed to read";
            }
        }
        catch
        {
            _textOut.text = "Failed in try";
        }
    }

    public void OnClickScan()
    {
        StartCoroutine(Scan());
    }

    private void UpdateCameraRender()
    {
        if (!_isCamAvaliable)
        {
            return;
        }
        float _ratio = (float)_camTexture.width / (float)_camTexture.height;
        _aspectRatioFitter.aspectRatio = _ratio;

        int orient = -_camTexture.videoRotationAngle;
        _rawImage.rectTransform.localEulerAngles = new Vector3(0, 0, orient);
    }
}
