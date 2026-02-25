using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Protocol.Dic;
using Protocol.Fresco;
using UI;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using Utils;

namespace Gameplay.Fresco.View
{
	// Token: 0x020007F6 RID: 2038
	[Token(Token = "0x20007F6")]
	public class FrescoFragment : MonoBehaviour
	{
		// Token: 0x1700095D RID: 2397
		// (get) Token: 0x06002FDD RID: 12253 RVA: 0x00009AC8 File Offset: 0x00007CC8
		[Token(Token = "0x1700095D")]
		public bool CanSelect
		{
			[Token(Token = "0x6002FDD")]
			[Address(RVA = "0x8043", Offset = "0x8043", VA = "0x8043")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700095E RID: 2398
		// (get) Token: 0x06002FDE RID: 12254 RVA: 0x00009AE0 File Offset: 0x00007CE0
		// (set) Token: 0x06002FDF RID: 12255 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700095E")]
		public bool IsSelected
		{
			[Token(Token = "0x6002FDE")]
			[Address(RVA = "0x8044", Offset = "0x8044", VA = "0x8044")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6002FDF")]
			[Address(RVA = "0x8045", Offset = "0x8045", VA = "0x8045")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700095F RID: 2399
		// (get) Token: 0x06002FE0 RID: 12256 RVA: 0x00009AF8 File Offset: 0x00007CF8
		// (set) Token: 0x06002FE1 RID: 12257 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700095F")]
		public FrescoCellState State
		{
			[Token(Token = "0x6002FE0")]
			[Address(RVA = "0x8046", Offset = "0x8046", VA = "0x8046")]
			[CompilerGenerated]
			get
			{
				return FrescoCellState.Empty;
			}
			[Token(Token = "0x6002FE1")]
			[Address(RVA = "0x8047", Offset = "0x8047", VA = "0x8047")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000960 RID: 2400
		// (get) Token: 0x06002FE2 RID: 12258 RVA: 0x00009B10 File Offset: 0x00007D10
		// (set) Token: 0x06002FE3 RID: 12259 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000960")]
		public uint Index
		{
			[Token(Token = "0x6002FE2")]
			[Address(RVA = "0x8048", Offset = "0x8048", VA = "0x8048")]
			[CompilerGenerated]
			get
			{
				return 0U;
			}
			[Token(Token = "0x6002FE3")]
			[Address(RVA = "0x8049", Offset = "0x8049", VA = "0x8049")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06002FE4 RID: 12260 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002FE4")]
		[Address(RVA = "0x804A", Offset = "0x804A", VA = "0x804A")]
		private void Start()
		{
		}

		// Token: 0x06002FE5 RID: 12261 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002FE5")]
		[Address(RVA = "0x804B", Offset = "0x804B", VA = "0x804B")]
		private void OnDestroy()
		{
		}

		// Token: 0x06002FE6 RID: 12262 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002FE6")]
		[Address(RVA = "0x804C", Offset = "0x804C", VA = "0x804C")]
		public void Init(FrescoCell cell, Protocol.Dic.Fresco.Types.Cell dicCell, [Optional] Action<FrescoFragment> onClick)
		{
		}

		// Token: 0x06002FE7 RID: 12263 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002FE7")]
		[Address(RVA = "0x804D", Offset = "0x804D", VA = "0x804D")]
		public void SetUvRect(Rect uvRect)
		{
		}

		// Token: 0x06002FE8 RID: 12264 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002FE8")]
		[Address(RVA = "0x804E", Offset = "0x804E", VA = "0x804E")]
		public void SetGrayscale(bool grayscale)
		{
		}

		// Token: 0x06002FE9 RID: 12265 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002FE9")]
		[Address(RVA = "0x804F", Offset = "0x804F", VA = "0x804F")]
		public void SetTexture(Texture texture)
		{
		}

		// Token: 0x06002FEA RID: 12266 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002FEA")]
		[Address(RVA = "0x8050", Offset = "0x8050", VA = "0x8050")]
		public void SwitchState(bool enable)
		{
		}

		// Token: 0x06002FEB RID: 12267 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002FEB")]
		[Address(RVA = "0x8051", Offset = "0x8051", VA = "0x8051")]
		public void SetBg(Sprite sprite)
		{
		}

		// Token: 0x06002FEC RID: 12268 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002FEC")]
		[Address(RVA = "0x8052", Offset = "0x8052", VA = "0x8052")]
		private void OnClickEventHandler(PointerEventData _)
		{
		}

		// Token: 0x06002FED RID: 12269 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002FED")]
		[Address(RVA = "0x8053", Offset = "0x8053", VA = "0x8053")]
		public void Click()
		{
		}

		// Token: 0x06002FEE RID: 12270 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002FEE")]
		[Address(RVA = "0x8054", Offset = "0x8054", VA = "0x8054")]
		public FrescoFragment()
		{
		}

		// Token: 0x04001A2A RID: 6698
		[Token(Token = "0x4001A2A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[SerializeField]
		private Image _bg;

		// Token: 0x04001A2B RID: 6699
		[Token(Token = "0x4001A2B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[SerializeField]
		private RawImageWithGrayscale _image;

		// Token: 0x04001A2C RID: 6700
		[Token(Token = "0x4001A2C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private MonoPointerClickHandler _clickHandler;

		// Token: 0x04001A2D RID: 6701
		[Token(Token = "0x4001A2D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private Action<FrescoFragment> _onClick;
	}
}
