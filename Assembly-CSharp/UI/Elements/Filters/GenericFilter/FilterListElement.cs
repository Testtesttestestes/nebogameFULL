using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace UI.Elements.Filters.GenericFilter
{
	// Token: 0x02000233 RID: 563
	[Token(Token = "0x2000233")]
	public class FilterListElement : MonoBehaviour
	{
		// Token: 0x140000F0 RID: 240
		// (add) Token: 0x06000DF3 RID: 3571 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06000DF4 RID: 3572 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140000F0")]
		public event Action<FilterListElement> ClickedEvent
		{
			[Token(Token = "0x6000DF3")]
			[Address(RVA = "0x1C7B", Offset = "0x1C7B", VA = "0x1C7B")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000DF4")]
			[Address(RVA = "0x6088", Offset = "0x6088", VA = "0x6088")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x170001D8 RID: 472
		// (get) Token: 0x06000DF5 RID: 3573 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06000DF6 RID: 3574 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170001D8")]
		public object Data
		{
			[Token(Token = "0x6000DF5")]
			[Address(RVA = "0x6089", Offset = "0x6089", VA = "0x6089")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000DF6")]
			[Address(RVA = "0x608A", Offset = "0x608A", VA = "0x608A")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170001D9 RID: 473
		// (get) Token: 0x06000DF7 RID: 3575 RVA: 0x000041A0 File Offset: 0x000023A0
		// (set) Token: 0x06000DF8 RID: 3576 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170001D9")]
		public bool Selected
		{
			[Token(Token = "0x6000DF7")]
			[Address(RVA = "0x608B", Offset = "0x608B", VA = "0x608B")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000DF8")]
			[Address(RVA = "0x608C", Offset = "0x608C", VA = "0x608C")]
			set
			{
			}
		}

		// Token: 0x06000DF9 RID: 3577 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000DF9")]
		[Address(RVA = "0x608D", Offset = "0x608D", VA = "0x608D")]
		private void Awake()
		{
		/* --- GHIDRA: Awake ---
		void Gameplay_VortexRating_View_GreatPrizesTab_FilterListElement__Awake
		               (int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  undefined4 param1_01;
		  
		  if (DAT_ram_00a581b5 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_VortexRating_View_GreatPrizesTab_FilterListElement_ButtonClickedEventHandler__
		              );
		    Mono_Security_ASN1__get_Item(&UnityEngine_Events_UnityAction_TypeInfo);
		    DAT_ram_00a581b5 = '\x01';
		  }
		  param1_01 = *(undefined4 *)(*(int *)(param1 + 0x18) + 0xb4);
		  param1_00 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		  Utils_ObjectUtils__IsNotNull
		            (param1_00,param1,
		             Method_Gameplay_VortexRating_View_GreatPrizesTab_FilterListElement_ButtonClickedEventHandler__
		             ,0);
		  UnityEngine_Events_UnityAction___ctor(param1_01,param1_00,0);
		  return;
		}
		*/

		/* --- GHIDRA: Awake ---
		void UI_Elements_Filters_GenericFilter_FilterListElement__Awake(int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  undefined4 param1_01;
		  
		  if (DAT_ram_00a6398b == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Elements_Filters_GenericFilter_FilterListElement_ButtonClickedEventHandler__
		              );
		    Mono_Security_ASN1__get_Item(&UnityEngine_Events_UnityAction_TypeInfo);
		    DAT_ram_00a6398b = '\x01';
		  }
		  param1_01 = *(undefined4 *)(*(int *)(param1 + 0x18) + 0xb4);
		  param1_00 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		  Utils_ObjectUtils__IsNotNull
		            (param1_00,param1,
		             Method_UI_Elements_Filters_GenericFilter_FilterListElement_ButtonClickedEventHandler__,
		             0);
		  UnityEngine_Events_UnityAction___ctor(param1_01,param1_00,0);
		  *(undefined4 *)(param1 + 0x20) = 0;
		  return;
		}
		*/

		}

		// Token: 0x06000DFA RID: 3578 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000DFA")]
		[Address(RVA = "0x608E", Offset = "0x608E", VA = "0x608E")]
		private void OnDestroy()
		{
		}

		// Token: 0x06000DFB RID: 3579 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000DFB")]
		[Address(RVA = "0x608F", Offset = "0x608F", VA = "0x608F")]
		private void ButtonClickedEventHandler()
		{
		/* --- GHIDRA: ButtonClickedEventHandler ---
		void Gameplay_VortexRating_View_GreatPrizesTab_FilterListElement__ButtonClickedEventHandler
		               (int param1,int param2,undefined4 param3)
		
		{
		  UnityEngine_Component__GetComponentInChildren_object_
		            (*(undefined4 *)(param1 + 0x10),*(undefined4 *)(param2 + 8),0);
		  *(undefined4 *)(param1 + 0x20) = *(undefined4 *)(param2 + 0xc);
		  return;
		}
		*/

		/* --- GHIDRA: ButtonClickedEventHandler ---
		void UI_Elements_Filters_GenericFilter_FilterListElement__ButtonClickedEventHandler
		               (int param1,int param2,undefined4 param3)
		
		{
		  UnityEngine_Component__GetComponentInChildren_object_
		            (*(undefined4 *)(param1 + 0x10),*(undefined4 *)(param2 + 8),0);
		  *(undefined4 *)(param1 + 0x24) = *(undefined4 *)(param2 + 0xc);
		  return;
		}
		*/

		}

		// Token: 0x06000DFC RID: 3580 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000DFC")]
		[Address(RVA = "0x6090", Offset = "0x6090", VA = "0x6090", Slot = "4")]
		public virtual void Init(FilterListElement.FilterData data)
		{
		}

		// Token: 0x06000DFD RID: 3581 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000DFD")]
		[Address(RVA = "0x6091", Offset = "0x6091", VA = "0x6091")]
		public FilterListElement()
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_VortexRating_View_GreatPrizesTab_FilterListElement___ctor
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a581b6 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_object__TypeInfo);
		    DAT_ram_00a581b6 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x18);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = UnityEngine_UI_Image__set_sprite(param1_00,param2,0);
		    param2_00 = System_Action_object__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_object__TypeInfo), iVar2 == 0)) break;
		    iVar2 = func_ii_4329(param1 + 0x18,iVar2,param1_00);
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

		/* --- GHIDRA: .ctor ---
		void UI_Elements_Filters_GenericFilter_FilterListElement___ctor
		               (int param1,int *param2,undefined4 param3)
		
		{
		  if (DAT_ram_00a6398c == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               UI_Elements_Filters_GenericFilter_FilterWithIconListElement_FilterWithIconData_TypeInfo
		              );
		    DAT_ram_00a6398c = '\x01';
		  }
		  UnityEngine_Component__GetComponentInChildren_object_(*(undefined4 *)(param1 + 0x10),param2[2],0);
		  *(int *)(param1 + 0x24) = param2[3];
		  if (((uint)*(byte *)(
		                      UI_Elements_Filters_GenericFilter_FilterWithIconListElement_FilterWithIconData_TypeInfo
		                      + 0xb8) <= (uint)*(byte *)(*param2 + 0xb8)) &&
		     (*(int *)(*(int *)(*param2 + 100) +
		               (uint)*(byte *)(
		                              UI_Elements_Filters_GenericFilter_FilterWithIconListElement_FilterWithIconData_TypeInfo
		                              + 0xb8) * 4 + -4) ==
		      UI_Elements_Filters_GenericFilter_FilterWithIconListElement_FilterWithIconData_TypeInfo)) {
		    AssetContent_GameImage__get_AssetId(*(undefined4 *)(param1 + 0x28),param2[4],0);
		    return;
		  }
		  System_Activator__CreateInstance
		            (param2,
		             UI_Elements_Filters_GenericFilter_FilterWithIconListElement_FilterWithIconData_TypeInfo
		            );
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}

		// Token: 0x040006E1 RID: 1761
		[Token(Token = "0x40006E1")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private TextMeshProUGUI _title;

		// Token: 0x040006E2 RID: 1762
		[Token(Token = "0x40006E2")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private GameObject _selector;

		// Token: 0x040006E3 RID: 1763
		[Token(Token = "0x40006E3")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Button _button;

		// Token: 0x040006E4 RID: 1764
		[Token(Token = "0x40006E4")]
		[FieldOffset(Offset = "0x1C")]
		private bool _selected;

		// Token: 0x02000234 RID: 564
		[Token(Token = "0x2000234")]
		public class FilterData
		{
			// Token: 0x06000DFE RID: 3582 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000DFE")]
			[Address(RVA = "0x1C7A", Offset = "0x1C7A", VA = "0x1C7A")]
			public FilterData()
			{
			}

			// Token: 0x040006E7 RID: 1767
			[Token(Token = "0x40006E7")]
			[FieldOffset(Offset = "0x8")]
			public string Title;

			// Token: 0x040006E8 RID: 1768
			[Token(Token = "0x40006E8")]
			[FieldOffset(Offset = "0xC")]
			public object Data;
		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_Selected ---
		void UI_Elements_Filters_GenericFilter_FilterListElement__get_Selected
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (*(undefined4 *)(param1 + 0x14),param2,0);
		  *(char *)(param1 + 0x1c) = (char)param2;
		  return;
		}
		*/


		/* --- GHIDRA: set_Selected ---
		void UI_Elements_Filters_GenericFilter_FilterListElement__set_Selected(int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  undefined4 param1_01;
		  
		  if (DAT_ram_00a6398a == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Elements_Filters_GenericFilter_FilterListElement_ButtonClickedEventHandler__
		              );
		    Mono_Security_ASN1__get_Item(&UnityEngine_Events_UnityAction_TypeInfo);
		    DAT_ram_00a6398a = '\x01';
		  }
		  param1_01 = *(undefined4 *)(*(int *)(param1 + 0x18) + 0xb4);
		  param1_00 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		  Utils_ObjectUtils__IsNotNull
		            (param1_00,param1,
		             Method_UI_Elements_Filters_GenericFilter_FilterListElement_ButtonClickedEventHandler__,
		             0);
		  Gameplay_Boss_View_CaptainTab_BossInfoView__add_AttackButtonClickEvent(param1_01,param1_00,0);
		  return;
		}
		*/


		/* --- GHIDRA: add_ClickedEvent ---
		void Gameplay_VortexRating_View_GreatPrizesTab_FilterListElement__add_ClickedEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a581b3 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_FilterListElement__TypeInfo);
		    DAT_ram_00a581b3 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x1c);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = func_ii_7048(param1_00,param2,0);
		    param2_00 = System_Action_FilterListElement__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_FilterListElement__TypeInfo), iVar2 == 0))
		    break;
		    iVar2 = func_ii_4329(param1 + 0x1c,iVar2,param1_00);
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


		/* --- GHIDRA: set_Data ---
		void Gameplay_VortexRating_View_GreatPrizesTab_FilterListElement__set_Data
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (*(undefined4 *)(param1 + 0x14),param2,0);
		  return;
		}
		*/


		/* --- GHIDRA: set_Selected ---
		void Gameplay_VortexRating_View_GreatPrizesTab_FilterListElement__set_Selected
		               (int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  undefined4 param1_01;
		  
		  if (DAT_ram_00a581b4 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_VortexRating_View_GreatPrizesTab_FilterListElement_ButtonClickedEventHandler__
		              );
		    Mono_Security_ASN1__get_Item(&UnityEngine_Events_UnityAction_TypeInfo);
		    DAT_ram_00a581b4 = '\x01';
		  }
		  param1_01 = *(undefined4 *)(*(int *)(param1 + 0x18) + 0xb4);
		  param1_00 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		  Utils_ObjectUtils__IsNotNull
		            (param1_00,param1,
		             Method_Gameplay_VortexRating_View_GreatPrizesTab_FilterListElement_ButtonClickedEventHandler__
		             ,0);
		  Gameplay_Boss_View_CaptainTab_BossInfoView__add_AttackButtonClickEvent(param1_01,param1_00,0);
		  return;
		}
		*/

}
