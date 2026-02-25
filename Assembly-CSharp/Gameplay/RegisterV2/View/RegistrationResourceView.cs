using System;
using AssetContent;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;

namespace Gameplay.RegisterV2.View
{
	// Token: 0x0200055B RID: 1371
	[Token(Token = "0x200055B")]
	public class RegistrationResourceView : MonoBehaviour
	{
		// Token: 0x17000607 RID: 1543
		// (get) Token: 0x060020F8 RID: 8440 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000607")]
		public GameRawImage Icon
		{
			[Token(Token = "0x60020F8")]
			[Address(RVA = "0x725B", Offset = "0x725B", VA = "0x725B")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000608 RID: 1544
		// (get) Token: 0x060020F9 RID: 8441 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060020FA RID: 8442 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000608")]
		public string IconAssetId
		{
			[Token(Token = "0x60020F9")]
			[Address(RVA = "0x725C", Offset = "0x725C", VA = "0x725C")]
			get
			{
				return null;
			}
			[Token(Token = "0x60020FA")]
			[Address(RVA = "0x725D", Offset = "0x725D", VA = "0x725D")]
			set
			{
			}
		}

		// Token: 0x17000609 RID: 1545
		// (set) Token: 0x060020FB RID: 8443 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000609")]
		public string Value
		{
			[Token(Token = "0x60020FB")]
			[Address(RVA = "0x725E", Offset = "0x725E", VA = "0x725E")]
			set
			{
			}
		}

		// Token: 0x060020FC RID: 8444 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60020FC")]
		[Address(RVA = "0x725F", Offset = "0x725F", VA = "0x725F")]
		public RegistrationResourceView()
		{
		}

		// Token: 0x040011FF RID: 4607
		[Token(Token = "0x40011FF")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private GameRawImage _icon;

		// Token: 0x04001200 RID: 4608
		[Token(Token = "0x4001200")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private TextMeshProUGUI _label;

		// Token: 0x04001201 RID: 4609
		[Token(Token = "0x4001201")]
		[FieldOffset(Offset = "0x18")]
		private string _iconAssetId;
	}
}
