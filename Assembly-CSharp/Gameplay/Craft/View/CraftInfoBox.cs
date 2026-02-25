using System;
using Core.Data;
using Gameplay.Inventory.View.Info.InfoBox;
using Il2CppDummyDll;
using Protocol.Craft;
using TMPro;
using UI;
using UI.Elements.Buttons;
using UI.Requirements;
using UI.Rewards;
using UnityEngine;
using UnityEngine.UI;

namespace Gameplay.Craft.View
{
	// Token: 0x020008AA RID: 2218
	[Token(Token = "0x20008AA")]
	public class CraftInfoBox : MonoBehaviourWithStates<CraftInfoBox.State>
	{
		// Token: 0x17000A50 RID: 2640
		// (get) Token: 0x06003410 RID: 13328 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000A50")]
		public Button CraftButton
		{
			[Token(Token = "0x6003410")]
			[Address(RVA = "0x843D", Offset = "0x843D", VA = "0x843D")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000A51 RID: 2641
		// (get) Token: 0x06003411 RID: 13329 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000A51")]
		public Button DeleteButton
		{
			[Token(Token = "0x6003411")]
			[Address(RVA = "0x843E", Offset = "0x843E", VA = "0x843E")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000A52 RID: 2642
		// (get) Token: 0x06003412 RID: 13330 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000A52")]
		public Button TakeButton
		{
			[Token(Token = "0x6003412")]
			[Address(RVA = "0x843F", Offset = "0x843F", VA = "0x843F")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000A53 RID: 2643
		// (get) Token: 0x06003413 RID: 13331 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000A53")]
		public Button SellAllButton
		{
			[Token(Token = "0x6003413")]
			[Address(RVA = "0x8440", Offset = "0x8440", VA = "0x8440")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000A54 RID: 2644
		// (get) Token: 0x06003414 RID: 13332 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000A54")]
		public ButtonWithCost AccelerateButton
		{
			[Token(Token = "0x6003414")]
			[Address(RVA = "0x8441", Offset = "0x8441", VA = "0x8441")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000A55 RID: 2645
		// (get) Token: 0x06003415 RID: 13333 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000A55")]
		public Button CancelButton
		{
			[Token(Token = "0x6003415")]
			[Address(RVA = "0x8442", Offset = "0x8442", VA = "0x8442")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000A56 RID: 2646
		// (get) Token: 0x06003416 RID: 13334 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000A56")]
		public ManufactureGroupView ManufactureGroup
		{
			[Token(Token = "0x6003416")]
			[Address(RVA = "0x8443", Offset = "0x8443", VA = "0x8443")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000A57 RID: 2647
		// (get) Token: 0x06003417 RID: 13335 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000A57")]
		public RentGroupView RentGroup
		{
			[Token(Token = "0x6003417")]
			[Address(RVA = "0x8444", Offset = "0x8444", VA = "0x8444")]
			get
			{
				return null;
			}
		}

		// Token: 0x06003418 RID: 13336 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003418")]
		[Address(RVA = "0x8445", Offset = "0x8445", VA = "0x8445")]
		public void UpdateInfo(UserData user, CraftSchemeData data, bool achieved)
		{
		}

		// Token: 0x06003419 RID: 13337 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003419")]
		[Address(RVA = "0x8446", Offset = "0x8446", VA = "0x8446")]
		private void DrawArtikulInfo(CraftSchemeData.CraftSchemeInfo info)
		{
		}

		// Token: 0x0600341A RID: 13338 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600341A")]
		[Address(RVA = "0x8447", Offset = "0x8447", VA = "0x8447")]
		public void DrawArtikulInfo(CraftSchemeData.CraftSchemeInfo info, UserCraftSlotInfo slotInfo)
		{
		}

		// Token: 0x0600341B RID: 13339 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600341B")]
		[Address(RVA = "0x8448", Offset = "0x8448", VA = "0x8448")]
		public void UpdateInfo(CraftSlotListElement element, UserData user)
		{
		}

		// Token: 0x0600341C RID: 13340 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600341C")]
		[Address(RVA = "0x8449", Offset = "0x8449", VA = "0x8449")]
		public void UpdateInfo(UserData user, CraftSlotListElement element, long expirationTime)
		{
		}

		// Token: 0x0600341D RID: 13341 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600341D")]
		[Address(RVA = "0x844A", Offset = "0x844A", VA = "0x844A")]
		private void DetermineActiveGroups(UserData user, CraftSlotListElement element, long expirationTime)
		{
		}

		// Token: 0x0600341E RID: 13342 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600341E")]
		[Address(RVA = "0x844B", Offset = "0x844B", VA = "0x844B")]
		private void HandleEmptySlot(CraftSlotListElement element)
		{
		}

		// Token: 0x0600341F RID: 13343 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600341F")]
		[Address(RVA = "0x844C", Offset = "0x844C", VA = "0x844C")]
		private void HandleInactiveSlot(UserData user, CraftSlotListElement element)
		{
		}

		// Token: 0x06003420 RID: 13344 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003420")]
		[Address(RVA = "0x844D", Offset = "0x844D", VA = "0x844D")]
		public CraftInfoBox()
		{
		}

		// Token: 0x04001C53 RID: 7251
		[Token(Token = "0x4001C53")]
		private const string LOCALIZATION_DURATION = "CRAFT/DURATION";

		// Token: 0x04001C54 RID: 7252
		[Token(Token = "0x4001C54")]
		private const string LOCALIZATION_EXPERIENCE = "CRAFT/EXPERIENCE";

		// Token: 0x04001C55 RID: 7253
		[Token(Token = "0x4001C55")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private RewardsRender _rewardsRender;

		// Token: 0x04001C56 RID: 7254
		[Token(Token = "0x4001C56")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private TextMeshProUGUI _artikulTitle;

		// Token: 0x04001C57 RID: 7255
		[Token(Token = "0x4001C57")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private TextMeshProUGUI _artikulDescription;

		// Token: 0x04001C58 RID: 7256
		[Token(Token = "0x4001C58")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private LoaderValueRowView _valueRow;

		// Token: 0x04001C59 RID: 7257
		[Token(Token = "0x4001C59")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private RequirementsView _requirementsView;

		// Token: 0x04001C5A RID: 7258
		[Token(Token = "0x4001C5A")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private TextMeshProUGUI _duration;

		// Token: 0x04001C5B RID: 7259
		[Token(Token = "0x4001C5B")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		private TextMeshProUGUI _experience;

		// Token: 0x04001C5C RID: 7260
		[Token(Token = "0x4001C5C")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Button _craftButton;

		// Token: 0x04001C5D RID: 7261
		[Token(Token = "0x4001C5D")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private Button _deleteButton;

		// Token: 0x04001C5E RID: 7262
		[Token(Token = "0x4001C5E")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private ButtonWithCost _accelerateButton;

		// Token: 0x04001C5F RID: 7263
		[Token(Token = "0x4001C5F")]
		[FieldOffset(Offset = "0x44")]
		[SerializeField]
		private Button _cancelButton;

		// Token: 0x04001C60 RID: 7264
		[Token(Token = "0x4001C60")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Button _takeButton;

		// Token: 0x04001C61 RID: 7265
		[Token(Token = "0x4001C61")]
		[FieldOffset(Offset = "0x4C")]
		[SerializeField]
		private Button _sellAllButton;

		// Token: 0x04001C62 RID: 7266
		[Token(Token = "0x4001C62")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private ManufactureGroupView _manufactureGroup;

		// Token: 0x04001C63 RID: 7267
		[Token(Token = "0x4001C63")]
		[FieldOffset(Offset = "0x54")]
		[SerializeField]
		private RentGroupView _rentGroup;

		// Token: 0x04001C64 RID: 7268
		[Token(Token = "0x4001C64")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private TextMeshProUGUI _freeSlotDescription;

		// Token: 0x020008AB RID: 2219
		[Token(Token = "0x20008AB")]
		public enum State
		{
			// Token: 0x04001C66 RID: 7270
			[Token(Token = "0x4001C66")]
			UNKNOWN_STATE,
			// Token: 0x04001C67 RID: 7271
			[Token(Token = "0x4001C67")]
			EMPTY_SLOT_INFO,
			// Token: 0x04001C68 RID: 7272
			[Token(Token = "0x4001C68")]
			INACTIVE_SLOT_INFO,
			// Token: 0x04001C69 RID: 7273
			[Token(Token = "0x4001C69")]
			CRAFT_SLOT_INFO,
			// Token: 0x04001C6A RID: 7274
			[Token(Token = "0x4001C6A")]
			RECIPE_INFO,
			// Token: 0x04001C6B RID: 7275
			[Token(Token = "0x4001C6B")]
			CRAFT_COMPLETED
		}
	}
}
