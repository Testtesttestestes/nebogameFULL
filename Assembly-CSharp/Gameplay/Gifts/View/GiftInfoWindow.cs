using System;
using Il2CppDummyDll;
using TMPro;
using UI.Windows;
using UnityEngine;

namespace Gameplay.Gifts.View
{
	// Token: 0x02000706 RID: 1798
	[Token(Token = "0x2000706")]
	public class GiftInfoWindow : ClosableBaseWindow<BaseWindowArgs>
	{
		// Token: 0x1700082C RID: 2092
		// (get) Token: 0x06002B0B RID: 11019 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700082C")]
		public override string WindowId
		{
			[Token(Token = "0x6002B0B")]
			[Address(RVA = "0x7BA6", Offset = "0x7BA6", VA = "0x7BA6", Slot = "14")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700082D RID: 2093
		// (get) Token: 0x06002B0C RID: 11020 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700082D")]
		public GiftView GiftView
		{
			[Token(Token = "0x6002B0C")]
			[Address(RVA = "0x7BA7", Offset = "0x7BA7", VA = "0x7BA7")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700082E RID: 2094
		// (get) Token: 0x06002B0D RID: 11021 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700082E")]
		public TextMeshProUGUI Annotation
		{
			[Token(Token = "0x6002B0D")]
			[Address(RVA = "0x7BA8", Offset = "0x7BA8", VA = "0x7BA8")]
			get
			{
				return null;
			}
		}

		// Token: 0x06002B0E RID: 11022 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002B0E")]
		[Address(RVA = "0x7BA9", Offset = "0x7BA9", VA = "0x7BA9")]
		public GiftInfoWindow()
		{
		}

		// Token: 0x04001781 RID: 6017
		[Token(Token = "0x4001781")]
		public const string WINDOW_ID = "Prefabs/UI/Windows/Gifts/GiftInfoWindow";

		// Token: 0x04001782 RID: 6018
		[Token(Token = "0x4001782")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private GiftView _giftView;

		// Token: 0x04001783 RID: 6019
		[Token(Token = "0x4001783")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private TextMeshProUGUI _annotation;

		// Token: 0x02000707 RID: 1799
		[Token(Token = "0x2000707")]
		public class GiftInfoWindowArgs : BaseWindowArgs
		{
			// Token: 0x06002B0F RID: 11023 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6002B0F")]
			[Address(RVA = "0x7BAA", Offset = "0x7BAA", VA = "0x7BAA")]
			public GiftInfoWindowArgs()
			{
			}
		}
	}
}
