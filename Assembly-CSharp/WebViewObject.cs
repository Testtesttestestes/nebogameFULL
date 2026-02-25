using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000010 RID: 16
[Token(Token = "0x2000010")]
public class WebViewObject : MonoBehaviour
{
	// Token: 0x060000C2 RID: 194 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60000C2")]
	[Address(RVA = "0x5587", Offset = "0x5587", VA = "0x5587")]
	private void Awake()
	{
	}

	// Token: 0x17000005 RID: 5
	// (get) Token: 0x060000C3 RID: 195 RVA: 0x000020D0 File Offset: 0x000002D0
	[Token(Token = "0x17000005")]
	public bool IsKeyboardVisible
	{
		[Token(Token = "0x60000C3")]
		[Address(RVA = "0x5588", Offset = "0x5588", VA = "0x5588")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x060000C4 RID: 196
	[Token(Token = "0x60000C4")]
	[Address(RVA = "0x5589", Offset = "0x5589", VA = "0x5589")]
	[PreserveSig]
	private static extern void _gree_unity_webview_init(string name);

	// Token: 0x060000C5 RID: 197
	[Token(Token = "0x60000C5")]
	[Address(RVA = "0x558A", Offset = "0x558A", VA = "0x558A")]
	[PreserveSig]
	private static extern void _gree_unity_webview_setMargins(string name, int left, int top, int right, int bottom);

	// Token: 0x060000C6 RID: 198
	[Token(Token = "0x60000C6")]
	[Address(RVA = "0x558B", Offset = "0x558B", VA = "0x558B")]
	[PreserveSig]
	private static extern void _gree_unity_webview_setVisibility(string name, bool visible);

	// Token: 0x060000C7 RID: 199
	[Token(Token = "0x60000C7")]
	[Address(RVA = "0x558C", Offset = "0x558C", VA = "0x558C")]
	[PreserveSig]
	private static extern void _gree_unity_webview_loadURL(string name, string url);

	// Token: 0x060000C8 RID: 200
	[Token(Token = "0x60000C8")]
	[Address(RVA = "0x558D", Offset = "0x558D", VA = "0x558D")]
	[PreserveSig]
	private static extern void _gree_unity_webview_evaluateJS(string name, string js);

	// Token: 0x060000C9 RID: 201
	[Token(Token = "0x60000C9")]
	[Address(RVA = "0x558E", Offset = "0x558E", VA = "0x558E")]
	[PreserveSig]
	private static extern void _gree_unity_webview_destroy(string name);

	// Token: 0x060000CA RID: 202 RVA: 0x000020E8 File Offset: 0x000002E8
	[Token(Token = "0x60000CA")]
	[Address(RVA = "0x558F", Offset = "0x558F", VA = "0x558F")]
	public static bool IsWebViewAvailable()
	{
		return default(bool);
	}

	// Token: 0x060000CB RID: 203 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60000CB")]
	[Address(RVA = "0x5590", Offset = "0x5590", VA = "0x5590")]
	public void Init([Optional] Action<string> cb, [Optional] Action<string> err, [Optional] Action<string> httpErr, [Optional] Action<string> ld, [Optional] Action<string> started, [Optional] Action<string> hooked, bool transparent = false, bool zoom = true, string ua = "", int androidForceDarkMode = 0, bool enableWKWebView = true, int wkContentMode = 0, bool wkAllowsLinkPreview = true, bool separated = false)
	{
	}

	// Token: 0x060000CC RID: 204 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60000CC")]
	[Address(RVA = "0x5591", Offset = "0x5591", VA = "0x5591", Slot = "4")]
	protected virtual void OnDestroy()
	{
	}

	// Token: 0x060000CD RID: 205 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60000CD")]
	[Address(RVA = "0x5592", Offset = "0x5592", VA = "0x5592")]
	public void Pause()
	{
	}

	// Token: 0x060000CE RID: 206 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60000CE")]
	[Address(RVA = "0x5593", Offset = "0x5593", VA = "0x5593")]
	public void Resume()
	{
	}

	// Token: 0x060000CF RID: 207 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60000CF")]
	[Address(RVA = "0x5594", Offset = "0x5594", VA = "0x5594")]
	public void SetCenterPositionWithScale(Vector2 center, Vector2 scale)
	{
	}

	// Token: 0x060000D0 RID: 208 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60000D0")]
	[Address(RVA = "0x5595", Offset = "0x5595", VA = "0x5595")]
	public void SetMargins(int left, int top, int right, int bottom, bool relative = false)
	{
	}

	// Token: 0x060000D1 RID: 209 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60000D1")]
	[Address(RVA = "0x5596", Offset = "0x5596", VA = "0x5596")]
	public void SetVisibility(bool v)
	{
	}

	// Token: 0x060000D2 RID: 210 RVA: 0x00002100 File Offset: 0x00000300
	[Token(Token = "0x60000D2")]
	[Address(RVA = "0x5597", Offset = "0x5597", VA = "0x5597")]
	public bool GetVisibility()
	{
		return default(bool);
	}

	// Token: 0x060000D3 RID: 211 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60000D3")]
	[Address(RVA = "0x5598", Offset = "0x5598", VA = "0x5598")]
	public void SetScrollbarsVisibility(bool v)
	{
	}

	// Token: 0x060000D4 RID: 212 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60000D4")]
	[Address(RVA = "0x5599", Offset = "0x5599", VA = "0x5599")]
	public void SetAlertDialogEnabled(bool e)
	{
	}

	// Token: 0x060000D5 RID: 213 RVA: 0x00002118 File Offset: 0x00000318
	[Token(Token = "0x60000D5")]
	[Address(RVA = "0x559A", Offset = "0x559A", VA = "0x559A")]
	public bool GetAlertDialogEnabled()
	{
		return default(bool);
	}

	// Token: 0x060000D6 RID: 214 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60000D6")]
	[Address(RVA = "0x559B", Offset = "0x559B", VA = "0x559B")]
	public void SetScrollBounceEnabled(bool e)
	{
	}

	// Token: 0x060000D7 RID: 215 RVA: 0x00002130 File Offset: 0x00000330
	[Token(Token = "0x60000D7")]
	[Address(RVA = "0x559C", Offset = "0x559C", VA = "0x559C")]
	public bool GetScrollBounceEnabled()
	{
		return default(bool);
	}

	// Token: 0x060000D8 RID: 216 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60000D8")]
	[Address(RVA = "0x559D", Offset = "0x559D", VA = "0x559D")]
	public void SetCameraAccess(bool allowed)
	{
	}

	// Token: 0x060000D9 RID: 217 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60000D9")]
	[Address(RVA = "0x559E", Offset = "0x559E", VA = "0x559E")]
	public void SetMicrophoneAccess(bool allowed)
	{
	}

	// Token: 0x060000DA RID: 218 RVA: 0x00002148 File Offset: 0x00000348
	[Token(Token = "0x60000DA")]
	[Address(RVA = "0x559F", Offset = "0x559F", VA = "0x559F")]
	public bool SetURLPattern(string allowPattern, string denyPattern, string hookPattern)
	{
		return default(bool);
	}

	// Token: 0x060000DB RID: 219 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60000DB")]
	[Address(RVA = "0x55A0", Offset = "0x55A0", VA = "0x55A0")]
	public void LoadURL(string url)
	{
	}

	// Token: 0x060000DC RID: 220 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60000DC")]
	[Address(RVA = "0x55A1", Offset = "0x55A1", VA = "0x55A1")]
	public void LoadHTML(string html, string baseUrl)
	{
	}

	// Token: 0x060000DD RID: 221 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60000DD")]
	[Address(RVA = "0x55A2", Offset = "0x55A2", VA = "0x55A2")]
	public void EvaluateJS(string js)
	{
	}

	// Token: 0x060000DE RID: 222 RVA: 0x00002160 File Offset: 0x00000360
	[Token(Token = "0x60000DE")]
	[Address(RVA = "0x55A3", Offset = "0x55A3", VA = "0x55A3")]
	public int Progress()
	{
		return 0;
	}

	// Token: 0x060000DF RID: 223 RVA: 0x00002178 File Offset: 0x00000378
	[Token(Token = "0x60000DF")]
	[Address(RVA = "0x55A4", Offset = "0x55A4", VA = "0x55A4")]
	public bool CanGoBack()
	{
		return default(bool);
	}

	// Token: 0x060000E0 RID: 224 RVA: 0x00002190 File Offset: 0x00000390
	[Token(Token = "0x60000E0")]
	[Address(RVA = "0x55A5", Offset = "0x55A5", VA = "0x55A5")]
	public bool CanGoForward()
	{
		return default(bool);
	}

	// Token: 0x060000E1 RID: 225 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60000E1")]
	[Address(RVA = "0x55A6", Offset = "0x55A6", VA = "0x55A6")]
	public void GoBack()
	{
	}

	// Token: 0x060000E2 RID: 226 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60000E2")]
	[Address(RVA = "0x55A7", Offset = "0x55A7", VA = "0x55A7")]
	public void GoForward()
	{
	}

	// Token: 0x060000E3 RID: 227 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60000E3")]
	[Address(RVA = "0x55A8", Offset = "0x55A8", VA = "0x55A8")]
	public void Reload()
	{
	}

	// Token: 0x060000E4 RID: 228 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60000E4")]
	[Address(RVA = "0x55A9", Offset = "0x55A9", VA = "0x55A9")]
	public void CallOnError(string error)
	{
	}

	// Token: 0x060000E5 RID: 229 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60000E5")]
	[Address(RVA = "0x55AA", Offset = "0x55AA", VA = "0x55AA")]
	public void CallOnHttpError(string error)
	{
	}

	// Token: 0x060000E6 RID: 230 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60000E6")]
	[Address(RVA = "0x55AB", Offset = "0x55AB", VA = "0x55AB")]
	public void CallOnStarted(string url)
	{
	}

	// Token: 0x060000E7 RID: 231 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60000E7")]
	[Address(RVA = "0x55AC", Offset = "0x55AC", VA = "0x55AC")]
	public void CallOnLoaded(string url)
	{
	}

	// Token: 0x060000E8 RID: 232 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60000E8")]
	[Address(RVA = "0x55AD", Offset = "0x55AD", VA = "0x55AD")]
	public void CallFromJS(string message)
	{
	}

	// Token: 0x060000E9 RID: 233 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60000E9")]
	[Address(RVA = "0x55AE", Offset = "0x55AE", VA = "0x55AE")]
	public void CallOnHooked(string message)
	{
	}

	// Token: 0x060000EA RID: 234 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60000EA")]
	[Address(RVA = "0x55AF", Offset = "0x55AF", VA = "0x55AF")]
	public void AddCustomHeader(string headerKey, string headerValue)
	{
	}

	// Token: 0x060000EB RID: 235 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60000EB")]
	[Address(RVA = "0x55B0", Offset = "0x55B0", VA = "0x55B0")]
	public string GetCustomHeaderValue(string headerKey)
	{
		return null;
	}

	// Token: 0x060000EC RID: 236 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60000EC")]
	[Address(RVA = "0x55B1", Offset = "0x55B1", VA = "0x55B1")]
	public void RemoveCustomHeader(string headerKey)
	{
	}

	// Token: 0x060000ED RID: 237 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60000ED")]
	[Address(RVA = "0x55B2", Offset = "0x55B2", VA = "0x55B2")]
	public void ClearCustomHeader()
	{
	}

	// Token: 0x060000EE RID: 238 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60000EE")]
	[Address(RVA = "0x55B3", Offset = "0x55B3", VA = "0x55B3")]
	public void ClearCookies()
	{
	}

	// Token: 0x060000EF RID: 239 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60000EF")]
	[Address(RVA = "0x55B4", Offset = "0x55B4", VA = "0x55B4")]
	public void SaveCookies()
	{
	}

	// Token: 0x060000F0 RID: 240 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60000F0")]
	[Address(RVA = "0x55B5", Offset = "0x55B5", VA = "0x55B5")]
	public string GetCookies(string url)
	{
		return null;
	}

	// Token: 0x060000F1 RID: 241 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60000F1")]
	[Address(RVA = "0x55B6", Offset = "0x55B6", VA = "0x55B6")]
	public void SetBasicAuthInfo(string userName, string password)
	{
	}

	// Token: 0x060000F2 RID: 242 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60000F2")]
	[Address(RVA = "0x55B7", Offset = "0x55B7", VA = "0x55B7")]
	public void ClearCache(bool includeDiskFiles)
	{
	}

	// Token: 0x060000F3 RID: 243 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60000F3")]
	[Address(RVA = "0x55B8", Offset = "0x55B8", VA = "0x55B8")]
	public void SetTextZoom(int textZoom)
	{
	}

	// Token: 0x060000F4 RID: 244 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60000F4")]
	[Address(RVA = "0x55B9", Offset = "0x55B9", VA = "0x55B9")]
	public WebViewObject()
	{
	}

	// Token: 0x0400002F RID: 47
	[Token(Token = "0x400002F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private Action<string> onJS;

	// Token: 0x04000030 RID: 48
	[Token(Token = "0x4000030")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	private Action<string> onError;

	// Token: 0x04000031 RID: 49
	[Token(Token = "0x4000031")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private Action<string> onHttpError;

	// Token: 0x04000032 RID: 50
	[Token(Token = "0x4000032")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	private Action<string> onStarted;

	// Token: 0x04000033 RID: 51
	[Token(Token = "0x4000033")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private Action<string> onLoaded;

	// Token: 0x04000034 RID: 52
	[Token(Token = "0x4000034")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	private Action<string> onHooked;

	// Token: 0x04000035 RID: 53
	[Token(Token = "0x4000035")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private bool visibility;

	// Token: 0x04000036 RID: 54
	[Token(Token = "0x4000036")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x29")]
	private bool alertDialogEnabled;

	// Token: 0x04000037 RID: 55
	[Token(Token = "0x4000037")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2A")]
	private bool scrollBounceEnabled;

	// Token: 0x04000038 RID: 56
	[Token(Token = "0x4000038")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	private int mMarginLeft;

	// Token: 0x04000039 RID: 57
	[Token(Token = "0x4000039")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private int mMarginTop;

	// Token: 0x0400003A RID: 58
	[Token(Token = "0x400003A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	private int mMarginRight;

	// Token: 0x0400003B RID: 59
	[Token(Token = "0x400003B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private int mMarginBottom;

	// Token: 0x0400003C RID: 60
	[Token(Token = "0x400003C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	private bool mMarginRelative;

	// Token: 0x0400003D RID: 61
	[Token(Token = "0x400003D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private float mMarginLeftComputed;

	// Token: 0x0400003E RID: 62
	[Token(Token = "0x400003E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	private float mMarginTopComputed;

	// Token: 0x0400003F RID: 63
	[Token(Token = "0x400003F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private float mMarginRightComputed;

	// Token: 0x04000040 RID: 64
	[Token(Token = "0x4000040")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	private float mMarginBottomComputed;

	// Token: 0x04000041 RID: 65
	[Token(Token = "0x4000041")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private bool mMarginRelativeComputed;

	// Token: 0x04000042 RID: 66
	[Token(Token = "0x4000042")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	private IntPtr webView;
}
