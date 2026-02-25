using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using TMPro;
using UI.Elements.GenericList;
using UnityEngine;
using UnityEngine.UI;

namespace Gameplay.Fresco.View.Groups
{
	// Token: 0x020007FC RID: 2044
	[Token(Token = "0x20007FC")]
	public class FrescoGroupListElement : GenericListElement<FrescoGroupListElementArgs>
	{
		// Token: 0x17000966 RID: 2406
		// (get) Token: 0x06002FFC RID: 12284 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06002FFD RID: 12285 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000966")]
		public FrescoGroupListElementArgs Data
		{
			[Token(Token = "0x6002FFC")]
			[Address(RVA = "0x8062", Offset = "0x8062", VA = "0x8062")]
			get
			{
				return null;
			}
			[Token(Token = "0x6002FFD")]
			[Address(RVA = "0x8063", Offset = "0x8063", VA = "0x8063")]
			set
			{
			}
		}

		// Token: 0x06002FFE RID: 12286 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002FFE")]
		[Address(RVA = "0x8064", Offset = "0x8064", VA = "0x8064", Slot = "4")]
		protected override void OnInit(FrescoGroupListElementArgs newArgs)
		{
		}

		// Token: 0x06002FFF RID: 12287 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002FFF")]
		[Address(RVA = "0x8065", Offset = "0x8065", VA = "0x8065")]
		private void ApplyArgs(FrescoGroupListElementArgs newArgs)
		{
		}

		// Token: 0x06003000 RID: 12288 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003000")]
		[Address(RVA = "0x8066", Offset = "0x8066", VA = "0x8066")]
		private void InitGroup(FrescoGroupListElementArgs newArgs)
		{
		}

		// Token: 0x06003001 RID: 12289 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003001")]
		[Address(RVA = "0x8067", Offset = "0x8067", VA = "0x8067")]
		private void ClearElements()
		{
		}

		// Token: 0x06003002 RID: 12290 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003002")]
		[Address(RVA = "0x8068", Offset = "0x8068", VA = "0x8068")]
		public FrescoGroupListElement()
		{
		}

		// Token: 0x04001A41 RID: 6721
		[Token(Token = "0x4001A41")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private FrescoListElement _frescoListElementPrefab;

		// Token: 0x04001A42 RID: 6722
		[Token(Token = "0x4001A42")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private HorizontalLayoutGroup _container;

		// Token: 0x04001A43 RID: 6723
		[Token(Token = "0x4001A43")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private TextMeshProUGUI _header;

		// Token: 0x04001A44 RID: 6724
		[Token(Token = "0x4001A44")]
		[FieldOffset(Offset = "0x2C")]
		private List<FrescoListElement> _elements;
	}
}
