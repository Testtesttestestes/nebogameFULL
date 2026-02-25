using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Protocol.Dic;
using TMPro;
using UI.ContextMenu;
using UI.Inventory;
using UnityEngine;
using UnityEngine.UI;

namespace Gameplay.Inventory.View.ContextMenu
{
	// Token: 0x0200067D RID: 1661
	[Token(Token = "0x200067D")]
	public class ArtifactContextMenu : MonoBehaviour, IContextMenu<ItemContextMenuOptions>, IBaseContextMenu
	{
		// Token: 0x14000155 RID: 341
		// (add) Token: 0x06002841 RID: 10305 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06002842 RID: 10306 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000155")]
		public static event Action<ArtikulMenuActionDic.Types.Actions> ActionHandledEvent
		{
			[Token(Token = "0x6002841")]
			[Address(RVA = "0x7961", Offset = "0x7961", VA = "0x7961")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6002842")]
			[Address(RVA = "0x7962", Offset = "0x7962", VA = "0x7962")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x06002843 RID: 10307 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002843")]
		[Address(RVA = "0x7963", Offset = "0x7963", VA = "0x7963", Slot = "4")]
		public void Show(ItemContextMenuOptions options)
		{
		}

		// Token: 0x06002844 RID: 10308 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002844")]
		[Address(RVA = "0x7964", Offset = "0x7964", VA = "0x7964")]
		private void ItemViewOnDataChangedEvent()
		{
		}

		// Token: 0x170007A2 RID: 1954
		// (get) Token: 0x06002845 RID: 10309 RVA: 0x00007A88 File Offset: 0x00005C88
		[Token(Token = "0x170007A2")]
		public Vector2 MenuSize
		{
			[Token(Token = "0x6002845")]
			[Address(RVA = "0x7965", Offset = "0x7965", VA = "0x7965", Slot = "5")]
			get
			{
				return default(Vector2);
			}
		}

		// Token: 0x06002846 RID: 10310 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002846")]
		[Address(RVA = "0x7966", Offset = "0x7966", VA = "0x7966")]
		private void ElementOnSelectEvent(ArtifactContextMenuElement element)
		{
		}

		// Token: 0x06002847 RID: 10311 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002847")]
		[Address(RVA = "0x7967", Offset = "0x7967", VA = "0x7967")]
		private void OnDestroy()
		{
		}

		// Token: 0x170007A3 RID: 1955
		// (get) Token: 0x06002848 RID: 10312 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170007A3")]
		public GameObject GameObject
		{
			[Token(Token = "0x6002848")]
			[Address(RVA = "0x7968", Offset = "0x7968", VA = "0x7968")]
			get
			{
				return null;
			}
		}

		// Token: 0x06002849 RID: 10313 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002849")]
		[Address(RVA = "0x7969", Offset = "0x7969", VA = "0x7969")]
		public ArtifactContextMenu()
		{
		}

		// Token: 0x0600284A RID: 10314 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600284A")]
		[Address(RVA = "0x796A", Offset = "0x796A", VA = "0x796A", Slot = "6")]
		private GameObject get_gameObject()
		{
			return null;
		}

		// Token: 0x0600284B RID: 10315 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600284B")]
		[Address(RVA = "0x796B", Offset = "0x796B", VA = "0x796B", Slot = "7")]
		private Transform get_transform()
		{
			return null;
		}

		// Token: 0x04001630 RID: 5680
		[Token(Token = "0x4001630")]
		public const ContextMenuId MenuId = ContextMenuId.Items;

		// Token: 0x04001632 RID: 5682
		[Token(Token = "0x4001632")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private Image _bg;

		// Token: 0x04001633 RID: 5683
		[Token(Token = "0x4001633")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private TextMeshProUGUI _itemTitleLabel;

		// Token: 0x04001634 RID: 5684
		[Token(Token = "0x4001634")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private ArtifactView _itemView;

		// Token: 0x04001635 RID: 5685
		[Token(Token = "0x4001635")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private ArtifactContextMenuElement[] _elements;

		// Token: 0x04001636 RID: 5686
		[Token(Token = "0x4001636")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Vector2 _menuSize;

		// Token: 0x04001637 RID: 5687
		[Token(Token = "0x4001637")]
		[FieldOffset(Offset = "0x28")]
		private ItemContextMenuOptions _options;
	}
}
