using System;
using System.Runtime.CompilerServices;
using Gameplay.GdEvents.Model.Milestone;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace Gameplay.GdEvents.View.Milestone
{
	// Token: 0x0200071F RID: 1823
	[Token(Token = "0x200071F")]
	public class MilestoneItemView : MonoBehaviour, IPointerClickHandler, IEventSystemHandler
	{
		// Token: 0x06002BA0 RID: 11168 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002BA0")]
		[Address(RVA = "0x7C37", Offset = "0x7C37", VA = "0x7C37")]
		private void OnDestroy()
		{
		}

		// Token: 0x17000850 RID: 2128
		// (get) Token: 0x06002BA1 RID: 11169 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06002BA2 RID: 11170 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000850")]
		public Action<MilestoneData> ClickCallback
		{
			[Token(Token = "0x6002BA1")]
			[Address(RVA = "0x7C38", Offset = "0x7C38", VA = "0x7C38")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6002BA2")]
			[Address(RVA = "0x7C39", Offset = "0x7C39", VA = "0x7C39")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000851 RID: 2129
		// (get) Token: 0x06002BA3 RID: 11171 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06002BA4 RID: 11172 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000851")]
		public MilestoneData Data
		{
			[Token(Token = "0x6002BA3")]
			[Address(RVA = "0x7C3A", Offset = "0x7C3A", VA = "0x7C3A")]
			get
			{
				return null;
			}
			[Token(Token = "0x6002BA4")]
			[Address(RVA = "0x7C3B", Offset = "0x7C3B", VA = "0x7C3B")]
			set
			{
			}
		}

		// Token: 0x06002BA5 RID: 11173 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002BA5")]
		[Address(RVA = "0x7C3C", Offset = "0x7C3C", VA = "0x7C3C")]
		private void HandleDataChanged()
		{
		/* --- GHIDRA: HandleDataChanged ---
		void Gameplay_GdEvents_View_Milestone_MilestoneItemView__HandleDataChanged
		               (int param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  int *piVar2;
		  int iVar3;
		  int local_4;
		  
		  if (DAT_ram_00a5a266 == '\0') {
		    Mono_Security_ASN1__get_Item(&StringLiteral_5);
		    DAT_ram_00a5a266 = '\x01';
		  }
		  piVar2 = *(int **)(param1 + 0x10);
		  local_4 = param2 + 1;
		  iVar1 = func_ii_4443(&local_4,0);
		  if (iVar1 == 0) {
		    iVar1 = StringLiteral_5;
		  }
		  iVar3 = *piVar2;
		  (**(code **)((ulonglong)*(uint *)(iVar3 + 0x2d0) * 4))
		            (piVar2,iVar1,*(undefined4 *)(iVar3 + 0x2d4));
		  return;
		}
		*/

		}

		// Token: 0x06002BA6 RID: 11174 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002BA6")]
		[Address(RVA = "0x7C3D", Offset = "0x7C3D", VA = "0x7C3D")]
		public void SetIndex(int itemIndex)
		{
		/* --- GHIDRA: SetIndex ---
		void Gameplay_GdEvents_View_Milestone_MilestoneItemView__SetIndex
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  
		  iVar1 = *(int *)(param1 + 0x2c);
		  (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		            (*(undefined4 *)(iVar1 + 0x20),*(undefined4 *)(param1 + 0x30),
		             *(undefined4 *)(iVar1 + 0x14));
		  return;
		}
		*/

		}

		// Token: 0x06002BA7 RID: 11175 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002BA7")]
		[Address(RVA = "0x7C3E", Offset = "0x7C3E", VA = "0x7C3E", Slot = "4")]
		public void OnPointerClick(PointerEventData eventData)
		{
		}

		// Token: 0x06002BA8 RID: 11176 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002BA8")]
		[Address(RVA = "0x7C3F", Offset = "0x7C3F", VA = "0x7C3F")]
		public MilestoneItemView()
		{
		}

		// Token: 0x040017E0 RID: 6112
		[Token(Token = "0x40017E0")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private TextMeshProUGUI _index;

		// Token: 0x040017E1 RID: 6113
		[Token(Token = "0x40017E1")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private TextMeshProUGUI _progressValueField;

		// Token: 0x040017E2 RID: 6114
		[Token(Token = "0x40017E2")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private TextMeshProUGUI _description;

		// Token: 0x040017E3 RID: 6115
		[Token(Token = "0x40017E3")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private Image _background;

		// Token: 0x040017E4 RID: 6116
		[Token(Token = "0x40017E4")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Image _progressCompleteIcon;

		// Token: 0x040017E5 RID: 6117
		[Token(Token = "0x40017E5")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private Image _selector;

		// Token: 0x040017E6 RID: 6118
		[Token(Token = "0x40017E6")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private MilestoneItemView.BgConfig[] _bgConfigs;

		// Token: 0x040017E8 RID: 6120
		[Token(Token = "0x40017E8")]
		[FieldOffset(Offset = "0x30")]
		private MilestoneData _data;

		// Token: 0x02000720 RID: 1824
		[Token(Token = "0x2000720")]
		[Serializable]
		public class BgConfig
		{
			// Token: 0x06002BA9 RID: 11177 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6002BA9")]
			[Address(RVA = "0x7C40", Offset = "0x7C40", VA = "0x7C40")]
			public BgConfig()
			{
			}

			// Token: 0x040017E9 RID: 6121
			[Token(Token = "0x40017E9")]
			[FieldOffset(Offset = "0x8")]
			public MilestoneProgressState _state;

			// Token: 0x040017EA RID: 6122
			[Token(Token = "0x40017EA")]
			[FieldOffset(Offset = "0xC")]
			public Sprite _sprite;
		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_Data ---
		void Gameplay_GdEvents_View_Milestone_MilestoneItemView__get_Data
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  *(undefined4 *)(param1 + 0x30) = param2;
		  Gameplay_GdEvents_View_Milestone_MilestoneItemView__set_Data(param1,param1);
		  return;
		}
		*/


		/* --- GHIDRA: set_Data ---
		void Gameplay_GdEvents_View_Milestone_MilestoneItemView__set_Data(int param1,undefined4 param2)
		
		{
		  bool bVar1;
		  int iVar2;
		  int iVar3;
		  float fVar4;
		  undefined4 uVar5;
		  int iVar6;
		  uint uVar7;
		  int iVar8;
		  int iVar9;
		  int *piVar10;
		  float4 local_4;
		  
		  bVar1 = false;
		  iVar3 = 0;
		  if (DAT_ram_00a5a265 == '\0') {
		    Mono_Security_ASN1__get_Item(&StringLiteral_28645);
		    DAT_ram_00a5a265 = '\x01';
		  }
		  iVar6 = *(int *)(param1 + 0x30);
		  if (iVar6 != 0) {
		    if (((*(char *)(*(int *)(*(int *)(iVar6 + 0x1c) + 0x10) + 0x10) == '\0') ||
		        (fVar4 = func_ii_8582(*(int *)(iVar6 + 0x1c),*(undefined4 *)(iVar6 + 8),iVar6), fVar4 <= 0.0
		        )) || ((0.0 < fVar4 && (iVar3 = 1, fVar4 < 1.0)))) {
		      uVar5 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                        (*(undefined4 *)(param1 + 0x14),0);
		      uVar7 = (uint)(*(char *)(*(int *)(*(int *)(*(int *)(param1 + 0x30) + 0x1c) + 0x10) + 0x10) !=
		                    '\0');
		    }
		    else {
		      iVar3 = 2;
		      bVar1 = true;
		      uVar5 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                        (*(undefined4 *)(param1 + 0x14),0);
		      uVar7 = 0;
		    }
		    Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		              (uVar5,uVar7,0);
		    uVar5 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                      (*(undefined4 *)(param1 + 0x20),0);
		    if (bVar1) {
		      uVar7 = (uint)(*(char *)(*(int *)(*(int *)(*(int *)(param1 + 0x30) + 0x1c) + 0x10) + 0x10) !=
		                    '\0');
		    }
		    else {
		      uVar7 = 0;
		    }
		    Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		              (uVar5,uVar7,0);
		    piVar10 = *(int **)(param1 + 0x14);
		    local_4 = (float4)Gameplay_GdEvents_Model_GdEventData__GetProgress
		                                (*(undefined4 *)(*(int *)(param1 + 0x30) + 0x1c),
		                                 *(undefined4 *)(*(int *)(param1 + 0x30) + 8),piVar10);
		    uVar5 = func_ii_1081(DAT_ram_00a6696c,&local_4);
		    uVar5 = func_ii_4419(StringLiteral_28645,uVar5,0);
		    (**(code **)((ulonglong)*(uint *)(*piVar10 + 0x2d0) * 4))
		              (piVar10,uVar5,*(undefined4 *)(*piVar10 + 0x2d4));
		    piVar10 = *(int **)(param1 + 0x18);
		    uVar5 = Core_Extensions_Dict_MilestoneExt__GetDescription
		                      (*(undefined4 *)(*(int *)(param1 + 0x30) + 8),0);
		    iVar6 = *piVar10;
		    (**(code **)((ulonglong)*(uint *)(iVar6 + 0x2d0) * 4))
		              (piVar10,uVar5,*(undefined4 *)(iVar6 + 0x2d4));
		    UnityEngine_Object__op_Implicit
		              (*(undefined4 *)(param1 + 0x24),(uint)*(byte *)(*(int *)(param1 + 0x30) + 0x24),0);
		    iVar8 = *(int *)(param1 + 0x28);
		    iVar6 = *(int *)(iVar8 + 0xc);
		    if (0 < iVar6) {
		      iVar2 = 0;
		      do {
		        iVar9 = *(int *)(iVar8 + iVar2 * 4 + 0x10);
		        if (iVar3 == *(int *)(iVar9 + 8)) {
		          func_ii_7050(*(undefined4 *)(param1 + 0x1c),*(undefined4 *)(iVar9 + 0xc),0);
		          iVar6 = *(int *)(iVar8 + 0xc);
		        }
		        iVar2 = iVar2 + 1;
		      } while (iVar2 < iVar6);
		    }
		  }
		  return;
		}
		*/

}
