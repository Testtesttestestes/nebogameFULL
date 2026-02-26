using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace UI.Sorting
{
	// Token: 0x0200017F RID: 383
	[Token(Token = "0x200017F")]
	public class SortControlOptionView : MonoBehaviour
	{
		// Token: 0x140000E0 RID: 224
		// (add) Token: 0x06000AD4 RID: 2772 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06000AD5 RID: 2773 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140000E0")]
		public event Action<SortControlOptionView> SelectEvent
		{
			[Token(Token = "0x6000AD4")]
			[Address(RVA = "0x2A50", Offset = "0x2A50", VA = "0x2A50")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000AD5")]
			[Address(RVA = "0x2A52", Offset = "0x2A52", VA = "0x2A52")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x17000171 RID: 369
		// (set) Token: 0x06000AD6 RID: 2774 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000171")]
		public string Label
		{
			[Token(Token = "0x6000AD6")]
			[Address(RVA = "0x2A4F", Offset = "0x2A4F", VA = "0x2A4F")]
			set
			{
			}
		}

		// Token: 0x06000AD7 RID: 2775 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000AD7")]
		[Address(RVA = "0x5E0C", Offset = "0x5E0C", VA = "0x5E0C")]
		private void Awake()
		{
		/* --- GHIDRA: Awake ---
		void UI_Sorting_SortControlOptionView__Awake(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  uint param2_00;
		  
		  uVar1 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (*(undefined4 *)(param1 + 0x20),0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (uVar1,(uint)*(byte *)(param1 + 0x28),0);
		  uVar1 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (*(undefined4 *)(param1 + 0x1c),0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (uVar1,(uint)(*(char *)(param1 + 0x28) == '\0'),0);
		  param2_00 = (uint)*(byte *)(*(int *)(param1 + 0x14) + 0xc4);
		  func_ii_7603(*(int *)(param1 + 0x14),param2_00,0);
		  uVar1 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (*(undefined4 *)(param1 + 0x18),0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (uVar1,param2_00,0);
		  return;
		}
		*/

		}

		// Token: 0x06000AD8 RID: 2776 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000AD8")]
		[Address(RVA = "0x5E0D", Offset = "0x5E0D", VA = "0x5E0D")]
		private void Start()
		{
		}

		// Token: 0x06000AD9 RID: 2777 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000AD9")]
		[Address(RVA = "0x5E0E", Offset = "0x5E0E", VA = "0x5E0E")]
		private void OnValueChangedEventHandler(bool arg0)
		{
		/* --- GHIDRA: OnValueChangedEventHandler ---
		void UI_Sorting_SortControlOptionView__OnValueChangedEventHandler(int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  undefined4 param1_01;
		  
		  if (DAT_ram_00a599e1 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_Sorting_SortControlOptionView_OnValueChangedEventHandler__);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Events_UnityAction_bool__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_Events_UnityEvent_bool__RemoveListener__);
		    DAT_ram_00a599e1 = '\x01';
		  }
		  param1_01 = *(undefined4 *)(*(int *)(param1 + 0x14) + 0xc0);
		  param1_00 = unnamed_function_1417(UnityEngine_Events_UnityAction_bool__TypeInfo);
		  UnityEngine_UI_Toggle__set_group
		            (param1_00,param1,Method_UI_Sorting_SortControlOptionView_OnValueChangedEventHandler__,0
		            );
		  UnityEngine_Events_UnityEvent_InputAction_CallbackContext___Invoke
		            (param1_01,param1_00,Method_UnityEngine_Events_UnityEvent_bool__RemoveListener__);
		  return;
		}
		*/

		}

		// Token: 0x06000ADA RID: 2778 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000ADA")]
		[Address(RVA = "0x5E0F", Offset = "0x5E0F", VA = "0x5E0F")]
		private void OnDestroy()
		{
		/* --- GHIDRA: OnDestroy ---
		void UI_Sorting_SortControlOptionView__OnDestroy(int param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 param1_00;
		  
		  func_ii_7603(*(undefined4 *)(param1 + 0x14),param2,0);
		  param1_00 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                        (*(undefined4 *)(param1 + 0x18),0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (param1_00,param2,0);
		  return;
		}
		*/

		}

		// Token: 0x06000ADB RID: 2779 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000ADB")]
		[Address(RVA = "0x5E10", Offset = "0x5E10", VA = "0x5E10")]
		public void SetIsOnWithoutNotify(bool value)
		{
		}

		// Token: 0x17000172 RID: 370
		// (get) Token: 0x06000ADC RID: 2780 RVA: 0x00003A20 File Offset: 0x00001C20
		// (set) Token: 0x06000ADD RID: 2781 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000172")]
		public bool IsDescending
		{
			[Token(Token = "0x6000ADC")]
			[Address(RVA = "0x5E11", Offset = "0x5E11", VA = "0x5E11")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000ADD")]
			[Address(RVA = "0x5E12", Offset = "0x5E12", VA = "0x5E12")]
			set
			{
			}
		}

		// Token: 0x06000ADE RID: 2782 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000ADE")]
		[Address(RVA = "0x5E13", Offset = "0x5E13", VA = "0x5E13")]
		private void HandleIsDescendingChanged()
		{
		}

		// Token: 0x06000ADF RID: 2783 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000ADF")]
		[Address(RVA = "0x5E14", Offset = "0x5E14", VA = "0x5E14")]
		public SortControlOptionView()
		{
		/* --- GHIDRA: .ctor ---
		void UI_Sorting_SortControlOptionView___ctor(int param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a599e2 == '\0') {
		    Mono_Security_ASN1__get_Item(&UnityEngine_Object_TypeInfo);
		    DAT_ram_00a599e2 = '\x01';
		  }
		  param1_00 = *(undefined4 *)(param1 + 0x20);
		  *(undefined4 *)(param1 + 0x20) = param2;
		  if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		    func_ii_306000(UnityEngine_Object_TypeInfo);
		  }
		  UnityEngine_Application__get_isPlaying(param1_00,0);
		  return;
		}
		*/

		}

		// Token: 0x040004CE RID: 1230
		[Token(Token = "0x40004CE")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private TextMeshProUGUI _label;

		// Token: 0x040004CF RID: 1231
		[Token(Token = "0x40004CF")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private Toggle _toggle;

		// Token: 0x040004D0 RID: 1232
		[Token(Token = "0x40004D0")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Transform _sortImagesOwner;

		// Token: 0x040004D1 RID: 1233
		[Token(Token = "0x40004D1")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private Transform _forwardSortImage;

		// Token: 0x040004D2 RID: 1234
		[Token(Token = "0x40004D2")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Transform _backwardImage;

		// Token: 0x040004D4 RID: 1236
		[Token(Token = "0x40004D4")]
		[FieldOffset(Offset = "0x28")]
		private bool _isDescending;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: remove_SelectEvent ---
		int * UI_Sorting_SortControlOptionView__remove_SelectEvent(int *param1)
		
		{
		  if (*param1 == 0) {
		    return param1;
		  }
		  System_Data_DataSet__ValidateLocaleConstraint(*param1);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/


		/* --- GHIDRA: set_Label ---
		void UI_Sorting_SortControlOptionView__set_Label(int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a599de == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_SortControlOptionView__TypeInfo);
		    DAT_ram_00a599de = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x24);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = UnityEngine_UI_Image__set_sprite(param1_00,param2,0);
		    param2_00 = System_Action_SortControlOptionView__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_SortControlOptionView__TypeInfo), iVar2 == 0))
		    break;
		    iVar2 = func_ii_4329(param1 + 0x24,iVar2,param1_00);
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


		/* --- GHIDRA: get_IsDescending ---
		void UI_Sorting_SortControlOptionView__get_IsDescending(int param1,uint param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  
		  if (param2 != *(byte *)(param1 + 0x28)) {
		    *(char *)(param1 + 0x28) = (char)param2;
		    uVar1 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                      (*(undefined4 *)(param1 + 0x20),0);
		    Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		              (uVar1,(uint)*(byte *)(param1 + 0x28),0);
		    uVar1 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                      (*(undefined4 *)(param1 + 0x1c),0);
		    Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		              (uVar1,(uint)(*(char *)(param1 + 0x28) == '\0'),0);
		  }
		  return;
		}
		*/


		/* --- GHIDRA: set_IsDescending ---
		void UI_Sorting_SortControlOptionView__set_IsDescending(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  
		  uVar1 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (*(undefined4 *)(param1 + 0x20),0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (uVar1,(uint)*(byte *)(param1 + 0x28),0);
		  uVar1 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (*(undefined4 *)(param1 + 0x1c),0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (uVar1,(uint)(*(char *)(param1 + 0x28) == '\0'),0);
		  return;
		}
		*/

}
