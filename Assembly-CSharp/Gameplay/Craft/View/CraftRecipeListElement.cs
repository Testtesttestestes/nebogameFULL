using System;
using System.Runtime.CompilerServices;
using Core.Data;
using Gameplay.Inventory.View;
using Il2CppDummyDll;
using TMPro;
using UI.Elements.GenericList;
using UnityEngine;

namespace Gameplay.Craft.View
{
	// Token: 0x020008AC RID: 2220
	[Token(Token = "0x20008AC")]
	public class CraftRecipeListElement : GenericListElement<CraftRecipeListElement.CraftRecipeListElementArgs>
	{
		// Token: 0x17000A58 RID: 2648
		// (get) Token: 0x06003421 RID: 13345 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06003422 RID: 13346 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000A58")]
		public CraftRecipeListElement.CraftRecipeListElementArgs Data
		{
			[Token(Token = "0x6003421")]
			[Address(RVA = "0x844E", Offset = "0x844E", VA = "0x844E")]
			get
			{
				return null;
			}
			[Token(Token = "0x6003422")]
			[Address(RVA = "0x844F", Offset = "0x844F", VA = "0x844F")]
			set
			{
			}
		}

		// Token: 0x06003423 RID: 13347 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003423")]
		[Address(RVA = "0x8450", Offset = "0x8450", VA = "0x8450")]
		private void Awake()
		{
		}

		// Token: 0x06003424 RID: 13348 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003424")]
		[Address(RVA = "0x8451", Offset = "0x8451", VA = "0x8451")]
		private void OnDestroy()
		{
		}

		// Token: 0x06003425 RID: 13349 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003425")]
		[Address(RVA = "0x8452", Offset = "0x8452", VA = "0x8452")]
		private void SelectChangedEventHandler(bool select)
		{
		}

		// Token: 0x06003426 RID: 13350 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003426")]
		[Address(RVA = "0x8453", Offset = "0x8453", VA = "0x8453")]
		private void CallElementClickedEvent(CraftRecipeListElement.CraftRecipeListElementArgs args)
		{
		}

		// Token: 0x06003427 RID: 13351 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003427")]
		[Address(RVA = "0x8454", Offset = "0x8454", VA = "0x8454", Slot = "4")]
		protected override void OnInit(CraftRecipeListElement.CraftRecipeListElementArgs args)
		{
		}

		// Token: 0x06003428 RID: 13352 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003428")]
		[Address(RVA = "0x8455", Offset = "0x8455", VA = "0x8455")]
		private void ApplyArgs()
		{
		}

		// Token: 0x06003429 RID: 13353 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003429")]
		[Address(RVA = "0x8456", Offset = "0x8456", VA = "0x8456")]
		private void Select(bool isSelected)
		{
		}

		// Token: 0x0600342A RID: 13354 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600342A")]
		[Address(RVA = "0x8457", Offset = "0x8457", VA = "0x8457")]
		public CraftRecipeListElement()
		{
		}

		// Token: 0x04001C6C RID: 7276
		[Token(Token = "0x4001C6C")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private TextMeshProUGUI _title;

		// Token: 0x04001C6D RID: 7277
		[Token(Token = "0x4001C6D")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private ArtikulView _artikulView;

		// Token: 0x04001C6E RID: 7278
		[Token(Token = "0x4001C6E")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _selectedImage;

		// Token: 0x04001C6F RID: 7279
		[Token(Token = "0x4001C6F")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private GameObject _bg;

		// Token: 0x020008AD RID: 2221
		[Token(Token = "0x20008AD")]
		public class CraftRecipeListElementArgs : GenericListElementArgs
		{
			// Token: 0x1400016E RID: 366
			// (add) Token: 0x0600342B RID: 13355 RVA: 0x00002050 File Offset: 0x00000250
			// (remove) Token: 0x0600342C RID: 13356 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x1400016E")]
			public event Action<bool> SelectChangedEvent
			{
				[Token(Token = "0x600342B")]
				[Address(RVA = "0x8458", Offset = "0x8458", VA = "0x8458")]
				[CompilerGenerated]
				add
				{
				}
				[Token(Token = "0x600342C")]
				[Address(RVA = "0x8459", Offset = "0x8459", VA = "0x8459")]
				[CompilerGenerated]
				remove
				{
				}
			}

			// Token: 0x17000A59 RID: 2649
			// (get) Token: 0x0600342D RID: 13357 RVA: 0x0000AA10 File Offset: 0x00008C10
			// (set) Token: 0x0600342E RID: 13358 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000A59")]
			public bool Selected
			{
				[Token(Token = "0x600342D")]
				[Address(RVA = "0x845A", Offset = "0x845A", VA = "0x845A")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x600342E")]
				[Address(RVA = "0x845B", Offset = "0x845B", VA = "0x845B")]
				set
				{
				}
			}

			// Token: 0x0600342F RID: 13359 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600342F")]
			[Address(RVA = "0x845C", Offset = "0x845C", VA = "0x845C")]
			public CraftRecipeListElementArgs()
			{
			}

			// Token: 0x04001C70 RID: 7280
			[Token(Token = "0x4001C70")]
			[FieldOffset(Offset = "0xC")]
			private bool _selected;

			// Token: 0x04001C71 RID: 7281
			[Token(Token = "0x4001C71")]
			[FieldOffset(Offset = "0x10")]
			public CraftSchemeData CraftData;

			// Token: 0x04001C72 RID: 7282
			[Token(Token = "0x4001C72")]
			[FieldOffset(Offset = "0x14")]
			public Action<CraftRecipeListElement> CraftRecipeButtonClickedEventHandler;
		}
	}
}
