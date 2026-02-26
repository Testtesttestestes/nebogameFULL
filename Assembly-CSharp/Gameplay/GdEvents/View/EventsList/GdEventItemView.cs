using System;
using System.Runtime.CompilerServices;
using AssetContent;
using Gameplay.GdEvents.Model.Categories;
using Gameplay.Inventory.View.Info.InfoBox;
using Il2CppDummyDll;
using TMPro;
using UI;
using UI.Elements.Counters;
using UnityEngine;
using UnityEngine.EventSystems;

namespace Gameplay.GdEvents.View.EventsList
{
	// Token: 0x02000734 RID: 1844
	[Token(Token = "0x2000734")]
	public class GdEventItemView : MonoBehaviourWithStates<Category>, IPointerClickHandler, IEventSystemHandler
	{
		// Token: 0x06002C01 RID: 11265 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002C01")]
		[Address(RVA = "0x7C91", Offset = "0x7C91", VA = "0x7C91")]
		private void OnDestroy()
		{
		}

		// Token: 0x17000860 RID: 2144
		// (get) Token: 0x06002C02 RID: 11266 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06002C03 RID: 11267 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000860")]
		public Action<CellModel> ClickCallback
		{
			[Token(Token = "0x6002C02")]
			[Address(RVA = "0x7C92", Offset = "0x7C92", VA = "0x7C92")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6002C03")]
			[Address(RVA = "0x7C93", Offset = "0x7C93", VA = "0x7C93")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000861 RID: 2145
		// (get) Token: 0x06002C04 RID: 11268 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06002C05 RID: 11269 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000861")]
		public CellModel Data
		{
			[Token(Token = "0x6002C04")]
			[Address(RVA = "0x7C94", Offset = "0x7C94", VA = "0x7C94")]
			get
			{
				return null;
			}
			[Token(Token = "0x6002C05")]
			[Address(RVA = "0x7C95", Offset = "0x7C95", VA = "0x7C95")]
			set
			{
			}
		}

		// Token: 0x06002C06 RID: 11270 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002C06")]
		[Address(RVA = "0x7C96", Offset = "0x7C96", VA = "0x7C96")]
		private void HandleDataChanged()
		{
		}

		// Token: 0x06002C07 RID: 11271 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002C07")]
		[Address(RVA = "0x7C97", Offset = "0x7C97", VA = "0x7C97", Slot = "5")]
		public void OnPointerClick(PointerEventData eventData)
		{
		/* --- GHIDRA: OnPointerClick ---
		void Gameplay_GdEvents_View_EventsList_GdEventItemView__OnPointerClick
		               (undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a5a292 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_UI_MonoBehaviourWithStates_Category___ctor__);
		    DAT_ram_00a5a292 = '\x01';
		  }
		  ScreenAdaptation_Common_AppSize__Update
		            (param1,Method_UI_MonoBehaviourWithStates_Category___ctor__);
		  return;
		}
		*/

		}

		// Token: 0x06002C08 RID: 11272 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002C08")]
		[Address(RVA = "0x7C98", Offset = "0x7C98", VA = "0x7C98")]
		public GdEventItemView()
		{
		/* --- GHIDRA: .ctor ---
		undefined4
		Gameplay_GdEvents_View_EventsList_GdEventItemView___ctor(undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a5a293 == '\0') {
		    Mono_Security_ASN1__get_Item(&StringLiteral_12621);
		    DAT_ram_00a5a293 = '\x01';
		  }
		  return StringLiteral_12621;
		}
		*/

		}

		// Token: 0x04001818 RID: 6168
		[Token(Token = "0x4001818")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private TextMeshProUGUI[] _titles;

		// Token: 0x04001819 RID: 6169
		[Token(Token = "0x4001819")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private CounterAutoHide _counter;

		// Token: 0x0400181A RID: 6170
		[Token(Token = "0x400181A")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private GameRawImage _backgroundImage;

		// Token: 0x0400181B RID: 6171
		[Token(Token = "0x400181B")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private BackTimeView _timer;

		// Token: 0x0400181C RID: 6172
		[Token(Token = "0x400181C")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private LoaderValueRowView _progressRow;

		// Token: 0x0400181E RID: 6174
		[Token(Token = "0x400181E")]
		[FieldOffset(Offset = "0x34")]
		private CellModel _data;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_Data ---
		void Gameplay_GdEvents_View_EventsList_GdEventItemView__get_Data
		               (int param1,int param2,undefined4 param3)
		
		{
		  if (param2 != *(int *)(param1 + 0x34)) {
		    *(int *)(param1 + 0x34) = param2;
		    Gameplay_GdEvents_View_EventsList_GdEventItemView__set_Data(param1,param1);
		  }
		  return;
		}
		*/


		/* --- GHIDRA: set_Data ---
		void Gameplay_GdEvents_View_EventsList_GdEventItemView__set_Data(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  undefined4 uVar2;
		  int iVar3;
		  int *piVar4;
		  int iVar5;
		  int iVar6;
		  
		  iVar3 = 0;
		  if (DAT_ram_00a5a291 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_UI_MonoBehaviourWithStates_Category__get_CurrentState__);
		    Mono_Security_ASN1__get_Item(&Method_UI_MonoBehaviourWithStates_Category__set_CurrentState__);
		    DAT_ram_00a5a291 = '\x01';
		  }
		  if (*(int *)(param1 + 0x34) == 0) {
		    iVar3 = *(int *)(param1 + 0x28);
		    if (*(int *)(iVar3 + 0x28) != 0) {
		      *(undefined4 *)(iVar3 + 0x28) = 0;
		      UI_Elements_RightPanel_TitleWithLevel__set_Level(*(undefined4 *)(iVar3 + 0x18),0,0);
		    }
		  }
		  else {
		    piVar4 = *(int **)(*(int *)(*(int *)(param1 + 0x34) + 0x14) + 0x14);
		    iVar5 = *piVar4;
		    uVar1 = (**(code **)((ulonglong)*(uint *)(iVar5 + 0xf0) * 4))
		                      (piVar4,*(undefined4 *)(iVar5 + 0xf4));
		    UI_MonoBehaviourWithStates_ByteEnum___remove_CurrentStateChangedEvent
		              (param1,uVar1,Method_UI_MonoBehaviourWithStates_Category__set_CurrentState__);
		    iVar5 = *(int *)(param1 + 0x1c);
		    if (0 < *(int *)(iVar5 + 0xc)) {
		      do {
		        piVar4 = *(int **)(iVar5 + iVar3 * 4 + 0x10);
		        uVar1 = Core_Extensions_Dict_GameActivityDicExt__GetWidgetImageAssetId
		                          (*(undefined4 *)(*(int *)(*(int *)(param1 + 0x34) + 0x14) + 0x10),0);
		        iVar6 = *piVar4;
		        (**(code **)((ulonglong)*(uint *)(iVar6 + 0x2d0) * 4))
		                  (piVar4,uVar1,*(undefined4 *)(iVar6 + 0x2d4));
		        iVar3 = iVar3 + 1;
		      } while (iVar3 < *(int *)(iVar5 + 0xc));
		    }
		    System_Collections_Generic_Dictionary_int__object___get_Count
		              (*(undefined4 *)(param1 + 0x20),
		               (uint)*(byte *)(*(int *)(*(int *)(param1 + 0x34) + 0x14) + 0x18),0);
		    uVar2 = *(undefined4 *)(param1 + 0x24);
		    uVar1 = Core_Extensions_Dict_GameEventExt__GetBigBannerAssetId
		                      (*(undefined4 *)(*(int *)(*(int *)(param1 + 0x34) + 0x14) + 0x10),0);
		    Core_Extensions_Dict_PortalDicExt__GetCurrencyIcon60x66(uVar2,uVar1,0);
		    iVar3 = *(int *)(param1 + 0x28);
		    iVar5 = *(int *)(*(int *)(param1 + 0x34) + 0x14);
		    *(undefined4 *)(iVar3 + 0x24) = *(undefined4 *)(*(int *)(iVar5 + 0x14) + 0x18);
		    if (*(int *)(iVar3 + 0x28) != iVar5) {
		      *(int *)(iVar3 + 0x28) = iVar5;
		      UI_Elements_RightPanel_TitleWithLevel__set_Level
		                (*(undefined4 *)(iVar3 + 0x18),*(undefined4 *)(iVar5 + 0xc),0);
		      Gameplay_GdEvents_View_BackTimeView__HandleDataChanged(iVar3,iVar5,iVar3);
		    }
		    if (*(char *)(param1 + 0x18) == '\x01') {
		      uVar2 = *(undefined4 *)(param1 + 0x2c);
		      uVar1 = Gameplay_GdEvents_Model_GdEventData__GetMilestones
		                        (*(undefined4 *)(*(int *)(param1 + 0x34) + 0x14),iVar3);
		      UI_Requirements_RequirementsView__GetRowPrefab(uVar2,uVar1,0);
		      return;
		    }
		  }
		  return;
		}
		*/

}
