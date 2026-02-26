using System;
using AssetContent;
using Gameplay.GdEvents.Model.Milestone;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;

namespace Gameplay.GdEvents.View.Milestone.Activity
{
	// Token: 0x02000731 RID: 1841
	[Token(Token = "0x2000731")]
	public class ActivityView : MonoBehaviour, IPointerClickHandler, IEventSystemHandler
	{
		// Token: 0x06002BEF RID: 11247 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002BEF")]
		[Address(RVA = "0x7C80", Offset = "0x7C80", VA = "0x7C80")]
		private void OnDestroy()
		{
		}

		// Token: 0x1700085D RID: 2141
		// (get) Token: 0x06002BF0 RID: 11248 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06002BF1 RID: 11249 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700085D")]
		public GameActivityData Data
		{
			[Token(Token = "0x6002BF0")]
			[Address(RVA = "0x7C81", Offset = "0x7C81", VA = "0x7C81")]
			get
			{
				return null;
			}
			[Token(Token = "0x6002BF1")]
			[Address(RVA = "0x7C82", Offset = "0x7C82", VA = "0x7C82")]
			set
			{
			}
		}

		// Token: 0x06002BF2 RID: 11250 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002BF2")]
		[Address(RVA = "0x7C83", Offset = "0x7C83", VA = "0x7C83")]
		private void HandleDataChanged()
		{
		/* --- GHIDRA: HandleDataChanged ---
		void Gameplay_GdEvents_View_Milestone_Activity_ActivityView__HandleDataChanged
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  if (DAT_ram_00a5a28b == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_Events_UnityEvent_GameActivityData__Invoke__);
		    DAT_ram_00a5a28b = '\x01';
		  }
		  func_ii_16397(*(undefined4 *)(param1 + 0x18),*(undefined4 *)(param1 + 0x1c),
		                Method_UnityEngine_Events_UnityEvent_GameActivityData__Invoke__);
		  return;
		}
		*/

		}

		// Token: 0x06002BF3 RID: 11251 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002BF3")]
		[Address(RVA = "0x7C84", Offset = "0x7C84", VA = "0x7C84", Slot = "4")]
		public void OnPointerClick(PointerEventData eventData)
		{
		/* --- GHIDRA: OnPointerClick ---
		void Gameplay_GdEvents_View_Milestone_Activity_ActivityView__OnPointerClick
		               (int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a5a28c == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_Events_UnityEvent_GameActivityData___ctor__);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Events_UnityEvent_GameActivityData__TypeInfo);
		    DAT_ram_00a5a28c = '\x01';
		  }
		  param1_00 = unnamed_function_1417(UnityEngine_Events_UnityEvent_GameActivityData__TypeInfo);
		  Sirenix_Serialization_UnityEventFormatter_object___GetUninitializedObject
		            (param1_00,Method_UnityEngine_Events_UnityEvent_GameActivityData___ctor__);
		  *(undefined4 *)(param1 + 0x18) = param1_00;
		  UnityEngine_RectTransform__GetParentSize(param1,0);
		  return;
		}
		*/

		}

		// Token: 0x06002BF4 RID: 11252 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002BF4")]
		[Address(RVA = "0x7C85", Offset = "0x7C85", VA = "0x7C85")]
		public ActivityView()
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_GdEvents_View_Milestone_Activity_ActivityView___ctor(int param1,undefined4 param2)
		
		{
		  func_ii_14558(*(undefined4 *)(param1 + 0x1c),0);
		  return;
		}
		*/

		}

		// Token: 0x0400180F RID: 6159
		[Token(Token = "0x400180F")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private TextMeshProUGUI _text;

		// Token: 0x04001810 RID: 6160
		[Token(Token = "0x4001810")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private GameAssetViewRawImage _image;

		// Token: 0x04001811 RID: 6161
		[Token(Token = "0x4001811")]
		[FieldOffset(Offset = "0x18")]
		[NonSerialized]
		public UnityEvent<GameActivityData> ClickEvent;

		// Token: 0x04001812 RID: 6162
		[Token(Token = "0x4001812")]
		[FieldOffset(Offset = "0x1C")]
		private GameActivityData _data;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_Data ---
		void Gameplay_GdEvents_View_Milestone_Activity_ActivityView__get_Data
		               (int param1,int param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  int *piVar2;
		  undefined4 param1_00;
		  int iVar3;
		  
		  if (param2 != *(int *)(param1 + 0x1c)) {
		    *(int *)(param1 + 0x1c) = param2;
		    piVar2 = *(int **)(param1 + 0x10);
		    uVar1 = Core_Extensions_Dict_FrescoGroupsDicExt__GetGroupTitle(*(undefined4 *)(param2 + 8),0);
		    iVar3 = *piVar2;
		    (**(code **)((ulonglong)*(uint *)(iVar3 + 0x2d0) * 4))
		              (piVar2,uVar1,*(undefined4 *)(iVar3 + 0x2d4));
		    param1_00 = *(undefined4 *)(param1 + 0x14);
		    uVar1 = Core_Extensions_Dict_GameActivityDicExt__GetTextOnWidget
		                      (*(undefined4 *)(*(int *)(param1 + 0x1c) + 8),0);
		    Core_Extensions_Dict_AprDicExt__Get1024AssetId(param1_00,uVar1,0);
		  }
		  return;
		}
		*/


		/* --- GHIDRA: set_Data ---
		void Gameplay_GdEvents_View_Milestone_Activity_ActivityView__set_Data(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  int *piVar2;
		  undefined4 param1_00;
		  int iVar3;
		  
		  piVar2 = *(int **)(param1 + 0x10);
		  uVar1 = Core_Extensions_Dict_FrescoGroupsDicExt__GetGroupTitle
		                    (*(undefined4 *)(*(int *)(param1 + 0x1c) + 8),0);
		  iVar3 = *piVar2;
		  (**(code **)((ulonglong)*(uint *)(iVar3 + 0x2d0) * 4))
		            (piVar2,uVar1,*(undefined4 *)(iVar3 + 0x2d4));
		  param1_00 = *(undefined4 *)(param1 + 0x14);
		  uVar1 = Core_Extensions_Dict_GameActivityDicExt__GetTextOnWidget
		                    (*(undefined4 *)(*(int *)(param1 + 0x1c) + 8),0);
		  Core_Extensions_Dict_AprDicExt__Get1024AssetId(param1_00,uVar1,0);
		  return;
		}
		*/

}
