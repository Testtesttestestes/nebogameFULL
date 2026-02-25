using System;
using System.Runtime.CompilerServices;
using Core.Data;
using Gameplay.Inventory.View;
using Il2CppDummyDll;
using Protocol.Craft;
using Protocol.Dic;
using TMPro;
using UI;
using UnityEngine;
using UnityEngine.UI;

namespace Gameplay.Craft.View
{
	// Token: 0x020008B2 RID: 2226
	[Token(Token = "0x20008B2")]
	public class CraftSlotListElement : MonoBehaviourWithStates<CraftSlotListElement.State>
	{
		// Token: 0x1400016F RID: 367
		// (add) Token: 0x06003447 RID: 13383 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06003448 RID: 13384 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1400016F")]
		public event Action<CraftSlotListElement> SelectedEvent
		{
			[Token(Token = "0x6003447")]
			[Address(RVA = "0x8474", Offset = "0x8474", VA = "0x8474")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6003448")]
			[Address(RVA = "0x8475", Offset = "0x8475", VA = "0x8475")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x17000A5E RID: 2654
		// (get) Token: 0x06003449 RID: 13385 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x0600344A RID: 13386 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000A5E")]
		public UserCraftSlotInfo SlotInfo
		{
			[Token(Token = "0x6003449")]
			[Address(RVA = "0x8476", Offset = "0x8476", VA = "0x8476")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600344A")]
			[Address(RVA = "0x8477", Offset = "0x8477", VA = "0x8477")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000A5F RID: 2655
		// (get) Token: 0x0600344B RID: 13387 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x0600344C RID: 13388 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000A5F")]
		public CraftSlotDic Dic
		{
			[Token(Token = "0x600344B")]
			[Address(RVA = "0x8478", Offset = "0x8478", VA = "0x8478")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600344C")]
			[Address(RVA = "0x8479", Offset = "0x8479", VA = "0x8479")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000A60 RID: 2656
		// (get) Token: 0x0600344D RID: 13389 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x0600344E RID: 13390 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000A60")]
		public CraftSchemeData.CraftSchemeInfo SchemeInfo
		{
			[Token(Token = "0x600344D")]
			[Address(RVA = "0x847A", Offset = "0x847A", VA = "0x847A")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600344E")]
			[Address(RVA = "0x847B", Offset = "0x847B", VA = "0x847B")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000A61 RID: 2657
		// (get) Token: 0x0600344F RID: 13391 RVA: 0x0000AA40 File Offset: 0x00008C40
		// (set) Token: 0x06003450 RID: 13392 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000A61")]
		public bool ManufactureSlot
		{
			[Token(Token = "0x600344F")]
			[Address(RVA = "0x847C", Offset = "0x847C", VA = "0x847C")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6003450")]
			[Address(RVA = "0x847D", Offset = "0x847D", VA = "0x847D")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06003451 RID: 13393 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003451")]
		[Address(RVA = "0x847E", Offset = "0x847E", VA = "0x847E")]
		private void Awake()
		{
		}

		// Token: 0x06003452 RID: 13394 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003452")]
		[Address(RVA = "0x847F", Offset = "0x847F", VA = "0x847F")]
		private void OnDestroy()
		{
		}

		// Token: 0x06003453 RID: 13395 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003453")]
		[Address(RVA = "0x8480", Offset = "0x8480", VA = "0x8480")]
		public void Init(CraftSlotDic dic, Action<CraftSlotListElement> selectCallback)
		{
		}

		// Token: 0x06003454 RID: 13396 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003454")]
		[Address(RVA = "0x8481", Offset = "0x8481", VA = "0x8481")]
		public void InitManufacture(Sprite manufactureBg)
		{
		}

		// Token: 0x06003455 RID: 13397 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003455")]
		[Address(RVA = "0x4499", Offset = "0x4499", VA = "0x4499")]
		public void FillWithData(CraftSchemeData.CraftSchemeInfo schemeInfo, UserCraftSlotInfo info)
		{
		}

		// Token: 0x06003456 RID: 13398 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003456")]
		[Address(RVA = "0x8482", Offset = "0x8482", VA = "0x8482")]
		public void Select(bool isSelected)
		{
		}

		// Token: 0x06003457 RID: 13399 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003457")]
		[Address(RVA = "0x8483", Offset = "0x8483", VA = "0x8483")]
		private void ButtonClickedEventHandler()
		{
		}

		// Token: 0x06003458 RID: 13400 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003458")]
		[Address(RVA = "0x449A", Offset = "0x449A", VA = "0x449A")]
		public void DisplayInactiveSlot()
		{
		}

		// Token: 0x06003459 RID: 13401 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003459")]
		[Address(RVA = "0x4497", Offset = "0x4497", VA = "0x4497")]
		public void DisplayEmptySlot(UserCraftSlotInfo slotInfo)
		{
		}

		// Token: 0x0600345A RID: 13402 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600345A")]
		[Address(RVA = "0x8484", Offset = "0x8484", VA = "0x8484")]
		public CraftSlotListElement()
		{
		}

		// Token: 0x04001C7A RID: 7290
		[Token(Token = "0x4001C7A")]
		private const string LOCALIZATION_OPEN_EXTRA_SLOT = "CRAFT/OPEN_EXTRA_SLOT";

		// Token: 0x04001C7B RID: 7291
		[Token(Token = "0x4001C7B")]
		private const string LOCALIZATION_INACTIVE_SLOT = "CRAFT/INACTIVE_SLOT";

		// Token: 0x04001C7C RID: 7292
		[Token(Token = "0x4001C7C")]
		private const string LOCALIZATION_ACTIVE_SLOT = "CRAFT/ACTIVE_SLOT";

		// Token: 0x04001C7D RID: 7293
		[Token(Token = "0x4001C7D")]
		private const string LOCALIZATION_CHOOSE_RECIPE = "CRAFT/CHOOSE_RECIPE";

		// Token: 0x04001C7E RID: 7294
		[Token(Token = "0x4001C7E")]
		private const string LOCALIZATION_MANUFACTURE_SLOT = "CRAFT/MANUFACTURE_SLOT";

		// Token: 0x04001C7F RID: 7295
		[Token(Token = "0x4001C7F")]
		private const string LOCALIZATION_STACK_PRODUCTION_AVAILABLE = "CRAFT/STACK_PRODUCTION_AVALIABLE";

		// Token: 0x04001C80 RID: 7296
		[Token(Token = "0x4001C80")]
		private const string LOCALIZATION_ACTIVATE_MANUFACTURE_ANNOTATION = "CRAFT/ACTIVATE_MANUFACTURE_ANNOTATION";

		// Token: 0x04001C81 RID: 7297
		[Token(Token = "0x4001C81")]
		private const string LOCALIZATION_MANUFACTURING = "CRAFT/MANUFACTURING";

		// Token: 0x04001C82 RID: 7298
		[Token(Token = "0x4001C82")]
		private const string LOCALIZATION_MANUFACTURING_COMPLETE = "CRAFT/MANUFACTURING_COMPLETE";

		// Token: 0x04001C83 RID: 7299
		[Token(Token = "0x4001C83")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private Button _button;

		// Token: 0x04001C84 RID: 7300
		[Token(Token = "0x4001C84")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private TextMeshProUGUI _title;

		// Token: 0x04001C85 RID: 7301
		[Token(Token = "0x4001C85")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private TextMeshProUGUI _description;

		// Token: 0x04001C86 RID: 7302
		[Token(Token = "0x4001C86")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private TextMeshProUGUI _statusText;

		// Token: 0x04001C87 RID: 7303
		[Token(Token = "0x4001C87")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private ArtikulView _artikulView;

		// Token: 0x04001C88 RID: 7304
		[Token(Token = "0x4001C88")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _selectedImage;

		// Token: 0x04001C89 RID: 7305
		[Token(Token = "0x4001C89")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		private GameObject _bg;

		// Token: 0x04001C8A RID: 7306
		[Token(Token = "0x4001C8A")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private TextMeshProUGUI _quantity;

		// Token: 0x04001C8B RID: 7307
		[Token(Token = "0x4001C8B")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private BacktimeViewUGUI _timer;

		// Token: 0x020008B3 RID: 2227
		[Token(Token = "0x20008B3")]
		public enum State
		{
			// Token: 0x04001C92 RID: 7314
			[Token(Token = "0x4001C92")]
			UNKNOWN_STATE,
			// Token: 0x04001C93 RID: 7315
			[Token(Token = "0x4001C93")]
			INACTIVE,
			// Token: 0x04001C94 RID: 7316
			[Token(Token = "0x4001C94")]
			EMPTY,
			// Token: 0x04001C95 RID: 7317
			[Token(Token = "0x4001C95")]
			FILLED
		}
	}
}
