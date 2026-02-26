using System;
using Gameplay.Aprs.View;
using Gameplay.Horde.Model.Data;
using Il2CppDummyDll;
using UI.Elements.GenericList;
using UnityEngine;

namespace Gameplay.Horde.View
{
	// Token: 0x020006FB RID: 1787
	[Token(Token = "0x20006FB")]
	public class HordeMonsterAprView : GenericListElement<HordeMonsterAprView.HordeMonsterAprViewArgs>
	{
		// Token: 0x1700081A RID: 2074
		// (get) Token: 0x06002ABD RID: 10941 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700081A")]
		public HordeMonsterData Data
		{
			[Token(Token = "0x6002ABD")]
			[Address(RVA = "0x7B58", Offset = "0x7B58", VA = "0x7B58")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700081B RID: 2075
		// (set) Token: 0x06002ABE RID: 10942 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700081B")]
		public bool Selected
		{
			[Token(Token = "0x6002ABE")]
			[Address(RVA = "0x7B59", Offset = "0x7B59", VA = "0x7B59")]
			set
			{
			}
		}

		// Token: 0x06002ABF RID: 10943 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002ABF")]
		[Address(RVA = "0x7B5A", Offset = "0x7B5A", VA = "0x7B5A")]
		private void Awake()
		{
		/* --- GHIDRA: Awake ---
		void Gameplay_Horde_View_HordeMonsterAprView__Awake(int param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (*(undefined4 *)(param1 + 0x28),1,0);
		  iVar1 = *(int *)(param2 + 0x14);
		  if (iVar1 != 0) {
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		              (*(undefined4 *)(iVar1 + 0x20),param1,*(undefined4 *)(iVar1 + 0x14));
		  }
		  return;
		}
		*/

		}

		// Token: 0x06002AC0 RID: 10944 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002AC0")]
		[Address(RVA = "0x7B5B", Offset = "0x7B5B", VA = "0x7B5B")]
		private void ClickEventHandler(HordeMonsterAprView.HordeMonsterAprViewArgs args)
		{
		/* --- GHIDRA: ClickEventHandler ---
		void Gameplay_Horde_View_HordeMonsterAprView__ClickEventHandler
		               (int param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  
		  iVar1 = **(int **)(param1 + 0x20);
		  (**(code **)((ulonglong)*(uint *)(iVar1 + 0x138) * 4))
		            (*(int **)(param1 + 0x20),*(undefined4 *)(*(int *)(*(int *)(param2 + 0xc) + 8) + 0xc),
		             *(undefined4 *)(iVar1 + 0x13c));
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (*(undefined4 *)(param1 + 0x24),(uint)*(byte *)(param2 + 0x10),0);
		  return;
		}
		*/

		}

		// Token: 0x06002AC1 RID: 10945 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002AC1")]
		[Address(RVA = "0x7B5C", Offset = "0x7B5C", VA = "0x7B5C", Slot = "4")]
		protected override void OnInit(HordeMonsterAprView.HordeMonsterAprViewArgs args)
		{
		/* --- GHIDRA: OnInit ---
		void Gameplay_Horde_View_HordeMonsterAprView__OnInit(undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a5a1f6 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Elements_GenericList_GenericListElement_HordeMonsterAprView_HordeMonsterAprViewArgs___ctor__
		              );
		    DAT_ram_00a5a1f6 = '\x01';
		  }
		  UI_Elements_GenericList_GenericListArgs___Il2CppFullySharedGenericType____ctor
		            (param1,
		             Method_UI_Elements_GenericList_GenericListElement_HordeMonsterAprView_HordeMonsterAprViewArgs___ctor__
		            );
		  return;
		}
		*/

		}

		// Token: 0x06002AC2 RID: 10946 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002AC2")]
		[Address(RVA = "0x7B5D", Offset = "0x7B5D", VA = "0x7B5D")]
		public HordeMonsterAprView()
		{
		}

		// Token: 0x04001756 RID: 5974
		[Token(Token = "0x4001756")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private AprViewSmall _aprView;

		// Token: 0x04001757 RID: 5975
		[Token(Token = "0x4001757")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private GameObject _defeatedImage;

		// Token: 0x04001758 RID: 5976
		[Token(Token = "0x4001758")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _selectedImage;

		// Token: 0x020006FC RID: 1788
		[Token(Token = "0x20006FC")]
		public class HordeMonsterAprViewArgs : GenericListElementArgs
		{
			// Token: 0x06002AC3 RID: 10947 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6002AC3")]
			[Address(RVA = "0x7B5E", Offset = "0x7B5E", VA = "0x7B5E")]
			public HordeMonsterAprViewArgs()
			{
			}

			// Token: 0x04001759 RID: 5977
			[Token(Token = "0x4001759")]
			[FieldOffset(Offset = "0xC")]
			public HordeMonsterData Data;

			// Token: 0x0400175A RID: 5978
			[Token(Token = "0x400175A")]
			[FieldOffset(Offset = "0x10")]
			public bool Defeated;

			// Token: 0x0400175B RID: 5979
			[Token(Token = "0x400175B")]
			[FieldOffset(Offset = "0x14")]
			public Action<HordeMonsterAprView> SelectedCallback;
		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_Data ---
		void Gameplay_Horde_View_HordeMonsterAprView__get_Data
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (*(undefined4 *)(param1 + 0x28),param2,0);
		  return;
		}
		*/


		/* --- GHIDRA: set_Selected ---
		void Gameplay_Horde_View_HordeMonsterAprView__set_Selected(int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  undefined4 param1_01;
		  
		  if (DAT_ram_00a5a1f5 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Horde_View_HordeMonsterAprView_ClickEventHandler__);
		    Mono_Security_ASN1__get_Item
		              (&UnityEngine_Events_UnityAction_HordeMonsterAprView_HordeMonsterAprViewArgs__TypeInfo
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UnityEngine_Events_UnityEvent_HordeMonsterAprView_HordeMonsterAprViewArgs__AddListener__
		              );
		    DAT_ram_00a5a1f5 = '\x01';
		  }
		  param1_01 = *(undefined4 *)(param1 + 0x14);
		  param1_00 = unnamed_function_1417
		                        (
		                        UnityEngine_Events_UnityAction_HordeMonsterAprView_HordeMonsterAprViewArgs__TypeInfo
		                        );
		  func_ii_7054(param1_00,param1,Method_Gameplay_Horde_View_HordeMonsterAprView_ClickEventHandler__,0
		              );
		  UnityEngine_Events_UnityEvent_InputAction_CallbackContext____ctor
		            (param1_01,param1_00,
		             Method_UnityEngine_Events_UnityEvent_HordeMonsterAprView_HordeMonsterAprViewArgs__AddListener__
		            );
		  return;
		}
		*/

}
