using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AssetContent;
using Core.Dict.DictWrappers.Wrappers;
using Core.Gameplay.Managers.Inventory;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Gameplay.GdEvents.View.EventView
{
	// Token: 0x02000741 RID: 1857
	[Token(Token = "0x2000741")]
	public class BattlePassGroupView : MonoBehaviour
	{
		// Token: 0x14000163 RID: 355
		// (add) Token: 0x06002C35 RID: 11317 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06002C36 RID: 11318 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000163")]
		private event Action ButtonClickedEvent
		{
			[Token(Token = "0x6002C35")]
			[Address(RVA = "0x7CC4", Offset = "0x7CC4", VA = "0x7CC4")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6002C36")]
			[Address(RVA = "0x7CC5", Offset = "0x7CC5", VA = "0x7CC5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x06002C37 RID: 11319 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002C37")]
		[Address(RVA = "0x7CC6", Offset = "0x7CC6", VA = "0x7CC6")]
		public void Init(InventoryManager inventoryManager, ArtikulDicWrapper artikul, IList<uint> optionIds)
		{
		}

		// Token: 0x06002C38 RID: 11320 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002C38")]
		[Address(RVA = "0x7CC7", Offset = "0x7CC7", VA = "0x7CC7")]
		private void DetermineBattlePassState(IList<uint> setIds)
		{
		}

		// Token: 0x06002C39 RID: 11321 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002C39")]
		[Address(RVA = "0x7CC8", Offset = "0x7CC8", VA = "0x7CC8")]
		private void Start()
		{
		}

		// Token: 0x06002C3A RID: 11322 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002C3A")]
		[Address(RVA = "0x7CC9", Offset = "0x7CC9", VA = "0x7CC9")]
		private void OnDestroy()
		{
		}

		// Token: 0x06002C3B RID: 11323 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002C3B")]
		[Address(RVA = "0x7CCA", Offset = "0x7CCA", VA = "0x7CCA")]
		private void ButtonClickedEventHandler()
		{
		}

		// Token: 0x06002C3C RID: 11324 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002C3C")]
		[Address(RVA = "0x7CCB", Offset = "0x7CCB", VA = "0x7CCB")]
		private void ShowNoBattlePassState()
		{
		}

		// Token: 0x06002C3D RID: 11325 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002C3D")]
		[Address(RVA = "0x7CCC", Offset = "0x7CCC", VA = "0x7CCC")]
		private void ShowBattlePassState()
		{
		}

		// Token: 0x06002C3E RID: 11326 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002C3E")]
		[Address(RVA = "0x7CCD", Offset = "0x7CCD", VA = "0x7CCD")]
		private void ShowBattlePassOptions()
		{
		}

		// Token: 0x06002C3F RID: 11327 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002C3F")]
		[Address(RVA = "0x7CCE", Offset = "0x7CCE", VA = "0x7CCE")]
		private void ShowFilteredInventory()
		{
		}

		// Token: 0x06002C40 RID: 11328 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002C40")]
		[Address(RVA = "0x7CCF", Offset = "0x7CCF", VA = "0x7CCF")]
		public BattlePassGroupView()
		{
		}

		// Token: 0x0400183C RID: 6204
		[Token(Token = "0x400183C")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private TextMeshProUGUI _text;

		// Token: 0x0400183D RID: 6205
		[Token(Token = "0x400183D")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private Button _button;

		// Token: 0x0400183E RID: 6206
		[Token(Token = "0x400183E")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameImage _icon;

		// Token: 0x0400183F RID: 6207
		[Token(Token = "0x400183F")]
		[FieldOffset(Offset = "0x1C")]
		private InventoryManager _inventoryManager;

		// Token: 0x04001840 RID: 6208
		[Token(Token = "0x4001840")]
		[FieldOffset(Offset = "0x20")]
		private IList<uint> _setIds;

		// Token: 0x04001841 RID: 6209
		[Token(Token = "0x4001841")]
		[FieldOffset(Offset = "0x24")]
		private IList<uint> _optionIds;
	}
}
