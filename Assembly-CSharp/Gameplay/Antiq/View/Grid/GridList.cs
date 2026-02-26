using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Com.TheFallenGames.OSA.CustomAdapters.GridView;
using Com.TheFallenGames.OSA.DataHelpers;
using Gameplay.Antiq.Model;
using Il2CppDummyDll;

namespace Gameplay.Antiq.View.Grid
{
	// Token: 0x02000D89 RID: 3465
	[Token(Token = "0x2000D89")]
	internal class GridList : GridAdapter<GridParams, CellHolder>
	{
		// Token: 0x14000202 RID: 514
		// (add) Token: 0x060054C9 RID: 21705 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x060054CA RID: 21706 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000202")]
		public event Action<GroupData> SelectEvent
		{
			[Token(Token = "0x60054C9")]
			[Address(RVA = "0xA275", Offset = "0xA275", VA = "0xA275")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60054CA")]
			[Address(RVA = "0xA276", Offset = "0xA276", VA = "0xA276")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x060054CB RID: 21707 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60054CB")]
		[Address(RVA = "0xA277", Offset = "0xA277", VA = "0xA277", Slot = "69")]
		protected override void Start()
		{
		/* --- GHIDRA: Start ---
		void Gameplay_Antiq_View_Grid_GridList__Start
		               (undefined4 param1,int param2,undefined4 param3,undefined4 param4)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int iVar2;
		  int param1_00;
		  undefined4 param1_01;
		  int param1_02;
		  int iVar3;
		  
		  if (DAT_ram_00a59492 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_GroupData__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Com_TheFallenGames_OSA_CustomAdapters_GridView_GridAdapter_GridParams__CellHolder__OnCellViewsHolderCreated__
		              );
		    Mono_Security_ASN1__get_Item(&Method_Gameplay_Antiq_View_Grid_GridList_HandleItemClickEvent__);
		    DAT_ram_00a59492 = '\x01';
		  }
		  iVar3 = *(int *)(param2 + 0x18);
		  param1_01 = unnamed_function_1417(System_Action_GroupData__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (param1_01,param1,Method_Gameplay_Antiq_View_Grid_GridList_HandleItemClickEvent__,0);
		  if (DAT_ram_00a5948a == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_GroupData__TypeInfo);
		    DAT_ram_00a5948a = '\x01';
		  }
		  param1_00 = *(int *)(iVar3 + 0x34);
		  while( true ) {
		    iVar2 = 0;
		    param1_02 = UnityEngine_UI_Image__set_sprite(param1_00,param1_01,0);
		    param2_00 = System_Action_GroupData__TypeInfo;
		    if ((param1_02 != 0) &&
		       (iVar2 = func_ii_1082(param1_02,System_Action_GroupData__TypeInfo), iVar2 == 0)) break;
		    iVar2 = func_ii_4329(iVar3 + 0x34,iVar2,param1_00);
		    bVar1 = iVar2 == param1_00;
		    param1_00 = iVar2;
		    if (bVar1) {
		      return;
		    }
		  }
		  System_Activator__CreateInstance(param1_02,param2_00);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}

		// Token: 0x060054CC RID: 21708 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60054CC")]
		[Address(RVA = "0xA278", Offset = "0xA278", VA = "0xA278", Slot = "127")]
		protected override void OnCellViewsHolderCreated(CellHolder cellVH, CellGroupViewsHolder<CellHolder> cellGroup)
		{
		/* --- GHIDRA: OnCellViewsHolderCreated ---
		void Gameplay_Antiq_View_Grid_GridList__OnCellViewsHolderCreated
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  
		  iVar1 = *(int *)(param1 + 0xb4);
		  if (iVar1 != 0) {
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		              (*(undefined4 *)(iVar1 + 0x20),param2,*(undefined4 *)(iVar1 + 0x14));
		  }
		  return;
		}
		*/

		}

		// Token: 0x060054CD RID: 21709 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60054CD")]
		[Address(RVA = "0xA279", Offset = "0xA279", VA = "0xA279")]
		private void HandleItemClickEvent(GroupData data)
		{
		/* --- GHIDRA: HandleItemClickEvent ---
		void Gameplay_Antiq_View_Grid_GridList__HandleItemClickEvent
		               (int param1,int *param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  undefined4 param1_00;
		  int iVar2;
		  
		  if (DAT_ram_00a59493 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Com_TheFallenGames_OSA_DataHelpers_SimpleDataHelper_GroupData__get_Item__);
		    DAT_ram_00a59493 = '\x01';
		  }
		  param1_00 = *(undefined4 *)(param1 + 0xb0);
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param2 + 0xe0) * 4))
		                    (param2,*(undefined4 *)(*param2 + 0xe4));
		  uVar1 = Com_TheFallenGames_OSA_DataHelpers_SimpleDataHelper_object___System_Collections_IEnumerable_GetEnumerator
		                    (param1_00,uVar1,
		                     Method_Com_TheFallenGames_OSA_DataHelpers_SimpleDataHelper_GroupData__get_Item__
		                    );
		  iVar2 = *(int *)param2[6];
		  (**(code **)((ulonglong)*(uint *)(iVar2 + 0x138) * 4))
		            ((int *)param2[6],uVar1,*(undefined4 *)(iVar2 + 0x13c));
		  return;
		}
		*/

		}

		// Token: 0x060054CE RID: 21710 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60054CE")]
		[Address(RVA = "0xA27A", Offset = "0xA27A", VA = "0xA27A", Slot = "128")]
		protected override void UpdateCellViewsHolder(CellHolder viewsHolder)
		{
		/* --- GHIDRA: UpdateCellViewsHolder ---
		void Gameplay_Antiq_View_Grid_GridList__UpdateCellViewsHolder(undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a59495 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Com_TheFallenGames_OSA_CustomAdapters_GridView_GridAdapter_GridParams__CellHolder___ctor__
		              );
		    DAT_ram_00a59495 = '\x01';
		  }
		  Sirenix_Utilities_GlobalConfig_object___get_ConfigAttribute
		            (param1,
		             Method_Com_TheFallenGames_OSA_CustomAdapters_GridView_GridAdapter_GridParams__CellHolder___ctor__
		            );
		  return;
		}
		*/

		}

		// Token: 0x060054CF RID: 21711 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60054CF")]
		[Address(RVA = "0x1D25", Offset = "0x1D25", VA = "0x1D25")]
		public void SetData(IList<GroupData> value)
		{
		/* --- GHIDRA: SetData ---
		void Gameplay_Antiq_View_Grid_GridList__SetData(int param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  
		  iVar1 = **(int **)(param1 + 0x14);
		  (**(code **)((ulonglong)*(uint *)(iVar1 + 0x2d0) * 4))
		            (*(int **)(param1 + 0x14),param2,*(undefined4 *)(iVar1 + 0x2d4));
		  return;
		}
		*/

		}

		// Token: 0x060054D0 RID: 21712 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60054D0")]
		[Address(RVA = "0xA27B", Offset = "0xA27B", VA = "0xA27B")]
		public GridList()
		{
		}

		// Token: 0x04002DF0 RID: 11760
		[Token(Token = "0x4002DF0")]
		[FieldOffset(Offset = "0xB0")]
		private SimpleDataHelper<GroupData> _data;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: add_SelectEvent ---
		void Gameplay_Antiq_View_Grid_GridList__add_SelectEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a59490 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_GroupData__TypeInfo);
		    DAT_ram_00a59490 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0xb4);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = func_ii_7048(param1_00,param2,0);
		    param2_00 = System_Action_GroupData__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_GroupData__TypeInfo), iVar2 == 0)) break;
		    iVar2 = func_ii_4329(param1 + 0xb4,iVar2,param1_00);
		    bVar1 = iVar2 == param1_00;
		    param1_00 = iVar2;
		    if (bVar1) {
		      return;
		    }
		  }
		  System_Activator__CreateInstance(param1_01,param2_00);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/


		/* --- GHIDRA: remove_SelectEvent ---
		void Gameplay_Antiq_View_Grid_GridList__remove_SelectEvent(int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a59491 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Com_TheFallenGames_OSA_Core_OSA_GridParams__CellGroupViewsHolder_CellHolder___Start__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Com_TheFallenGames_OSA_Core_OSA_GridParams__CellGroupViewsHolder_CellHolder___get_IsInitialized__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_Com_TheFallenGames_OSA_DataHelpers_SimpleDataHelper_GroupData___ctor__);
		    Mono_Security_ASN1__get_Item
		              (&Com_TheFallenGames_OSA_DataHelpers_SimpleDataHelper_GroupData__TypeInfo);
		    DAT_ram_00a59491 = '\x01';
		  }
		  if (*(char *)(param1 + 0x50) == '\0') {
		    param1_00 = unnamed_function_1417
		                          (Com_TheFallenGames_OSA_DataHelpers_SimpleDataHelper_GroupData__TypeInfo);
		    System_Collections_Generic_ShortEnumEqualityComparer___Il2CppFullySharedGenericStructType___GetHashCode
		              (param1_00,param1,1,
		               Method_Com_TheFallenGames_OSA_DataHelpers_SimpleDataHelper_GroupData___ctor__);
		    *(undefined4 *)(param1 + 0xb0) = param1_00;
		    Com_TheFallenGames_OSA_Core_OSA_object__object___SmoothScrollTo
		              (param1,
		               Method_Com_TheFallenGames_OSA_Core_OSA_GridParams__CellGroupViewsHolder_CellHolder___Start__
		              );
		  }
		  return;
		}
		*/

}
