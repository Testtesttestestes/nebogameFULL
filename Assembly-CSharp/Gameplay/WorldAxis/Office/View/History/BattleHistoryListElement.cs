using System;
using AssetContent;
using Core.Data;
using Il2CppDummyDll;
using Protocol.Colossus;
using Protocol.Dic;
using TMPro;
using UI.Elements.GenericList;
using UnityEngine;
using UnityEngine.UI;

namespace Gameplay.WorldAxis.Office.View.History
{
	// Token: 0x0200030E RID: 782
	[Token(Token = "0x200030E")]
	public class BattleHistoryListElement : SelectableListElement<BattleHistoryListElement.BattleHistoryListElementArgs>
	{
		// Token: 0x0600122E RID: 4654 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600122E")]
		[Address(RVA = "0x6429", Offset = "0x6429", VA = "0x6429", Slot = "11")]
		protected override void ApplyArgs()
		{
		/* --- GHIDRA: ApplyArgs ---
		void Gameplay_WorldAxis_Office_View_History_BattleHistoryListElement__ApplyArgs
		               (int param1,int param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  int iVar3;
		  undefined4 uVar4;
		  undefined4 param1_00;
		  int iVar5;
		  int *piVar6;
		  
		  iVar5 = 0;
		  if (DAT_ram_00a58bb7 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_Object_Instantiate_ValueIconTitleValue___);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Object_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_WorldAxis_Office_View_History_ValueIconTitleValue___TypeInfo);
		    DAT_ram_00a58bb7 = '\x01';
		  }
		  if (*(char *)(param1 + 0x58) == '\0') {
		    *(undefined1 *)(param1 + 0x58) = 1;
		    uVar1 = Mono_Security_ASN1Convert__ToOid
		                      (Gameplay_WorldAxis_Office_View_History_ValueIconTitleValue___TypeInfo,
		                       *(undefined4 *)(*(int *)(param2 + 0x2c) + 0xc));
		    *(undefined4 *)(param1 + 0x54) = uVar1;
		    iVar3 = *(int *)(param2 + 0x2c);
		    if (0 < *(int *)(iVar3 + 0xc)) {
		      do {
		        uVar1 = *(undefined4 *)(iVar3 + iVar5 * 4 + 0x10);
		        uVar4 = *(undefined4 *)(param1 + 0x40);
		        param1_00 = *(undefined4 *)(param1 + 0x3c);
		        if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		          func_ii_306000(UnityEngine_Object_TypeInfo);
		        }
		        iVar3 = func_ii_6805(param1_00,uVar4,
		                             Method_UnityEngine_Object_Instantiate_ValueIconTitleValue___);
		        uVar4 = Core_Extensions_Dict_ColossusFragmentsOptionsDicExt__GetEventPromoDescription
		                          (uVar1,0);
		        UnityEngine_Component__GetComponentInChildren_object_(*(undefined4 *)(iVar3 + 0x18),uVar4,0)
		        ;
		        uVar1 = Core_Extensions_Dict_ColossusRatingDicExt__GetDescription(uVar1,0);
		        AssetContent_GameImage__get_AssetId(*(undefined4 *)(iVar3 + 0x1c),uVar1,0);
		        piVar6 = *(int **)(param1 + 0x54);
		        iVar2 = func_ii_1082(iVar3,*(undefined4 *)(*piVar6 + 0x20));
		        if (iVar2 == 0) {
		          uVar1 = func_ii_1083();
		          func_ii_1050(uVar1,0);
		          do {
		            halt_trap();
		          } while( true );
		        }
		        piVar6[iVar5 + 4] = iVar3;
		        iVar5 = iVar5 + 1;
		        iVar3 = *(int *)(param2 + 0x2c);
		      } while (iVar5 < *(int *)(iVar3 + 0xc));
		    }
		  }
		  return;
		}
		*/

		}

		// Token: 0x0600122F RID: 4655 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600122F")]
		[Address(RVA = "0x642A", Offset = "0x642A", VA = "0x642A")]
		private void PrepareView(BattleHistoryListElement.BattleHistoryListElementArgs args)
		{
		}

		// Token: 0x06001230 RID: 4656 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001230")]
		[Address(RVA = "0x642B", Offset = "0x642B", VA = "0x642B", Slot = "10")]
		protected override void CallElementClickedEvent(BattleHistoryListElement.BattleHistoryListElementArgs args)
		{
		/* --- GHIDRA: CallElementClickedEvent ---
		void Gameplay_WorldAxis_Office_View_History_BattleHistoryListElement__CallElementClickedEvent
		               (undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a58bb8 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Elements_GenericList_SelectableListElement_BattleHistoryListElement_BattleHistoryListElementArgs___ctor__
		              );
		    DAT_ram_00a58bb8 = '\x01';
		  }
		  UI_Elements_GenericList_SelectableListElementArgs___Il2CppFullySharedGenericType____ctor
		            (param1,
		             Method_UI_Elements_GenericList_SelectableListElement_BattleHistoryListElement_BattleHistoryListElementArgs___ctor__
		            );
		  return;
		}
		*/

		}

		// Token: 0x06001231 RID: 4657 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001231")]
		[Address(RVA = "0x642C", Offset = "0x642C", VA = "0x642C")]
		public BattleHistoryListElement()
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_WorldAxis_Office_View_History_BattleHistoryListElement___ctor
		               (undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a58bb9 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Elements_GenericList_SelectableListElementArgs_BattleHistoryListElement___ctor__
		              );
		    DAT_ram_00a58bb9 = '\x01';
		  }
		  UnityEngine_InputSystem_LowLevel_SelectObservable___Il2CppFullySharedGenericType____Il2CppFullySharedGenericType___Subscribe
		            (param1,
		             Method_UI_Elements_GenericList_SelectableListElementArgs_BattleHistoryListElement___ctor__
		            );
		  return;
		}
		*/

		}

		// Token: 0x04000999 RID: 2457
		[Token(Token = "0x4000999")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private TextMeshProUGUI _colossusTitle;

		// Token: 0x0400099A RID: 2458
		[Token(Token = "0x400099A")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameImage _leftClanIcon;

		// Token: 0x0400099B RID: 2459
		[Token(Token = "0x400099B")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private GameImage _rightClanIcon;

		// Token: 0x0400099C RID: 2460
		[Token(Token = "0x400099C")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private TextMeshProUGUI _leftClanTitle;

		// Token: 0x0400099D RID: 2461
		[Token(Token = "0x400099D")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		private TextMeshProUGUI _rightClanTitle;

		// Token: 0x0400099E RID: 2462
		[Token(Token = "0x400099E")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private TextMeshProUGUI _dateTime;

		// Token: 0x0400099F RID: 2463
		[Token(Token = "0x400099F")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private ValueIconTitleValue _rowPrefab;

		// Token: 0x040009A0 RID: 2464
		[Token(Token = "0x40009A0")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private RectTransform _content;

		// Token: 0x040009A1 RID: 2465
		[Token(Token = "0x40009A1")]
		[FieldOffset(Offset = "0x44")]
		[SerializeField]
		private Image _glowImage;

		// Token: 0x040009A2 RID: 2466
		[Token(Token = "0x40009A2")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Sprite _neutralGlow;

		// Token: 0x040009A3 RID: 2467
		[Token(Token = "0x40009A3")]
		[FieldOffset(Offset = "0x4C")]
		[SerializeField]
		private Sprite _winGlow;

		// Token: 0x040009A4 RID: 2468
		[Token(Token = "0x40009A4")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Sprite _loseGlow;

		// Token: 0x040009A5 RID: 2469
		[Token(Token = "0x40009A5")]
		[FieldOffset(Offset = "0x54")]
		private ValueIconTitleValue[] _rows;

		// Token: 0x040009A6 RID: 2470
		[Token(Token = "0x40009A6")]
		[FieldOffset(Offset = "0x58")]
		private bool _viewPrepared;

		// Token: 0x0200030F RID: 783
		[Token(Token = "0x200030F")]
		public class BattleHistoryListElementArgs : SelectableListElementArgs<BattleHistoryListElement>
		{
			// Token: 0x06001232 RID: 4658 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001232")]
			[Address(RVA = "0x642D", Offset = "0x642D", VA = "0x642D")]
			public BattleHistoryListElementArgs()
			{
			}

			// Token: 0x040009A7 RID: 2471
			[Token(Token = "0x40009A7")]
			[FieldOffset(Offset = "0x1C")]
			public ProtoGetColossusBattlesAns.Types.ColossusBattle Battle;

			// Token: 0x040009A8 RID: 2472
			[Token(Token = "0x40009A8")]
			[FieldOffset(Offset = "0x20")]
			public ColossusDic ColossusDic;

			// Token: 0x040009A9 RID: 2473
			[Token(Token = "0x40009A9")]
			[FieldOffset(Offset = "0x24")]
			public string WinnerClanCultAssetId;

			// Token: 0x040009AA RID: 2474
			[Token(Token = "0x40009AA")]
			[FieldOffset(Offset = "0x28")]
			public string LoserClanCultAssetId;

			// Token: 0x040009AB RID: 2475
			[Token(Token = "0x40009AB")]
			[FieldOffset(Offset = "0x2C")]
			public ColossusRatingDic[] ValidRatings;

			// Token: 0x040009AC RID: 2476
			[Token(Token = "0x40009AC")]
			[FieldOffset(Offset = "0x30")]
			public UserData User;
		}
	}
}
