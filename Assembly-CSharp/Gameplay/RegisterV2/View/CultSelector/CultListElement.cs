using System;
using AssetContent;
using Il2CppDummyDll;
using UI.Elements.GenericList;
using UnityEngine;
using UnityEngine.UI;

namespace Gameplay.RegisterV2.View.CultSelector
{
	// Token: 0x02000566 RID: 1382
	[Token(Token = "0x2000566")]
	public class CultListElement : SelectedGenericListElement<CultListElementArgs>
	{
		// Token: 0x17000619 RID: 1561
		// (get) Token: 0x06002150 RID: 8528 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000619")]
		public GameRawImage CultImage
		{
			[Token(Token = "0x6002150")]
			[Address(RVA = "0x72B2", Offset = "0x72B2", VA = "0x72B2")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700061A RID: 1562
		// (get) Token: 0x06002151 RID: 8529 RVA: 0x00006A80 File Offset: 0x00004C80
		// (set) Token: 0x06002152 RID: 8530 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700061A")]
		public override bool Selected
		{
			[Token(Token = "0x6002151")]
			[Address(RVA = "0x72B3", Offset = "0x72B3", VA = "0x72B3", Slot = "7")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6002152")]
			[Address(RVA = "0x72B4", Offset = "0x72B4", VA = "0x72B4", Slot = "8")]
			set
			{
			}
		}

		// Token: 0x06002153 RID: 8531 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002153")]
		[Address(RVA = "0x72B5", Offset = "0x72B5", VA = "0x72B5", Slot = "4")]
		protected override void OnInit(CultListElementArgs args)
		{
		}

		// Token: 0x06002154 RID: 8532 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002154")]
		[Address(RVA = "0x72B6", Offset = "0x72B6", VA = "0x72B6")]
		public CultListElement()
		{
		}

		// Token: 0x04001233 RID: 4659
		[Token(Token = "0x4001233")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameRawImage _cultImage;

		// Token: 0x04001234 RID: 4660
		[Token(Token = "0x4001234")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private Image _selectedImage;
	}
}
