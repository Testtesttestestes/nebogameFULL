using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace UI.Filters
{
	// Token: 0x020001E9 RID: 489
	[Token(Token = "0x20001E9")]
	public class SimpleToggleWithData : MonoBehaviour
	{
		// Token: 0x170001A5 RID: 421
		// (get) Token: 0x06000C9F RID: 3231 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06000CA0 RID: 3232 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170001A5")]
		public object Data
		{
			[Token(Token = "0x6000C9F")]
			[Address(RVA = "0x5FA2", Offset = "0x5FA2", VA = "0x5FA2")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000CA0")]
			[Address(RVA = "0x5FA3", Offset = "0x5FA3", VA = "0x5FA3")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170001A6 RID: 422
		// (get) Token: 0x06000CA1 RID: 3233 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170001A6")]
		public Toggle Toggle
		{
			[Token(Token = "0x6000CA1")]
			[Address(RVA = "0x5FA4", Offset = "0x5FA4", VA = "0x5FA4")]
			get
			{
				return null;
			}
		}

		// Token: 0x170001A7 RID: 423
		// (get) Token: 0x06000CA2 RID: 3234 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170001A7")]
		public Image BG
		{
			[Token(Token = "0x6000CA2")]
			[Address(RVA = "0x5FA5", Offset = "0x5FA5", VA = "0x5FA5")]
			get
			{
				return null;
			}
		}

		// Token: 0x140000E7 RID: 231
		// (add) Token: 0x06000CA3 RID: 3235 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06000CA4 RID: 3236 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140000E7")]
		public event Action<SimpleToggleWithData> ToggleEvent
		{
			[Token(Token = "0x6000CA3")]
			[Address(RVA = "0x5FA6", Offset = "0x5FA6", VA = "0x5FA6")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000CA4")]
			[Address(RVA = "0x5FA7", Offset = "0x5FA7", VA = "0x5FA7")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x06000CA5 RID: 3237 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000CA5")]
		[Address(RVA = "0x5FA8", Offset = "0x5FA8", VA = "0x5FA8")]
		public void Init(object data, [Optional] string text)
		{
		}

		// Token: 0x06000CA6 RID: 3238 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000CA6")]
		[Address(RVA = "0x5FA9", Offset = "0x5FA9", VA = "0x5FA9")]
		private void Awake()
		{
		}

		// Token: 0x06000CA7 RID: 3239 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000CA7")]
		[Address(RVA = "0x5FAA", Offset = "0x5FAA", VA = "0x5FAA")]
		private void OnDestroy()
		{
		}

		// Token: 0x06000CA8 RID: 3240 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000CA8")]
		[Address(RVA = "0x5FAB", Offset = "0x5FAB", VA = "0x5FAB")]
		private void ToggleClickedEventHandler(bool enable)
		{
		}

		// Token: 0x06000CA9 RID: 3241 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000CA9")]
		[Address(RVA = "0x5FAC", Offset = "0x5FAC", VA = "0x5FAC")]
		public SimpleToggleWithData()
		{
		}

		// Token: 0x04000625 RID: 1573
		[Token(Token = "0x4000625")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[SerializeField]
		private TextMeshProUGUI _text;

		// Token: 0x04000626 RID: 1574
		[Token(Token = "0x4000626")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[SerializeField]
		private Toggle _toggle;

		// Token: 0x04000627 RID: 1575
		[Token(Token = "0x4000627")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Image _bg;
	}
}
