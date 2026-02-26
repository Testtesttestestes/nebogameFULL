using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Gameplay.Craft.View;
using Gameplay.Medals.View;
using Il2CppDummyDll;
using TMPro;
using UI.Toggle;
using UnityEngine;

namespace UI.Filters
{
	// Token: 0x020001E0 RID: 480
	[Token(Token = "0x20001E0")]
	public class FiltersView : MonoBehaviour
	{
		// Token: 0x1700019F RID: 415
		// (get) Token: 0x06000C73 RID: 3187 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700019F")]
		public FilterButton PriceFilterButton
		{
			[Token(Token = "0x6000C73")]
			[Address(RVA = "0x5F77", Offset = "0x5F77", VA = "0x5F77")]
			get
			{
				return null;
			}
		}

		// Token: 0x140000E5 RID: 229
		// (add) Token: 0x06000C74 RID: 3188 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06000C75 RID: 3189 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140000E5")]
		public event Action ChangedEvent
		{
			[Token(Token = "0x6000C74")]
			[Address(RVA = "0x5F78", Offset = "0x5F78", VA = "0x5F78")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000C75")]
			[Address(RVA = "0x5F79", Offset = "0x5F79", VA = "0x5F79")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x170001A0 RID: 416
		// (get) Token: 0x06000C76 RID: 3190 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170001A0")]
		public List<FilterInfo> FiltersInfo
		{
			[Token(Token = "0x6000C76")]
			[Address(RVA = "0x5F7A", Offset = "0x5F7A", VA = "0x5F7A")]
			get
			{
				return null;
			}
		}

		// Token: 0x170001A1 RID: 417
		// (get) Token: 0x06000C77 RID: 3191 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170001A1")]
		public Dictionary<FilterInfo.FilterType, FilterInfo> FiltersInfoDictionary
		{
			[Token(Token = "0x6000C77")]
			[Address(RVA = "0x5F7B", Offset = "0x5F7B", VA = "0x5F7B")]
			get
			{
				return null;
			}
		}

		// Token: 0x170001A2 RID: 418
		// (get) Token: 0x06000C78 RID: 3192 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170001A2")]
		public GameObject AchievedToggle
		{
			[Token(Token = "0x6000C78")]
			[Address(RVA = "0x5F7C", Offset = "0x5F7C", VA = "0x5F7C")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000C79 RID: 3193 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C79")]
		[Address(RVA = "0x5F7D", Offset = "0x5F7D", VA = "0x5F7D")]
		private void Awake()
		{
		/* --- GHIDRA: Awake ---
		void UI_Filters_FiltersView__Awake(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  if (DAT_ram_00a63920 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_FilterInfo_FilterType__FilterInfo__get_Item__
		              );
		    DAT_ram_00a63920 = '\x01';
		  }
		  iVar1 = GAFInternal_Reader_GAFReader__OpenTag
		                    (*(undefined4 *)(param1 + 0x38),5,
		                     Method_System_Collections_Generic_Dictionary_FilterInfo_FilterType__FilterInfo__get_Item__
		                    );
		  *(undefined1 *)(iVar1 + 0x10) = *(undefined1 *)(*(int *)(param1 + 0x20) + 0x48);
		  iVar1 = *(int *)(param1 + 0x30);
		  if (iVar1 != 0) {
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		              (*(undefined4 *)(iVar1 + 0x20),*(undefined4 *)(iVar1 + 0x14));
		  }
		  return;
		}
		*/

		}

		// Token: 0x06000C7A RID: 3194 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C7A")]
		[Address(RVA = "0x5F7E", Offset = "0x5F7E", VA = "0x5F7E")]
		private void AchievedToggleOnChangedEvent()
		{
		/* --- GHIDRA: AchievedToggleOnChangedEvent ---
		void UI_Filters_FiltersView__AchievedToggleOnChangedEvent
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  undefined4 uVar1;
		  undefined4 param3_00;
		  int *piVar2;
		  int iVar3;
		  undefined4 local_8;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a63921 == '\0') {
		    Mono_Security_ASN1__get_Item(&StringLiteral_28672);
		    DAT_ram_00a63921 = '\x01';
		  }
		  piVar2 = *(int **)(param1 + 0x2c);
		  local_4 = param2;
		  uVar1 = func_ii_1081(DAT_ram_00a66954,&local_4);
		  local_8 = param3;
		  param3_00 = func_ii_1081(DAT_ram_00a66954,&local_8);
		  uVar1 = System_Collections_Generic_Dictionary_int__object___ContainsKey
		                    (StringLiteral_28672,uVar1,param3_00,0);
		  iVar3 = *piVar2;
		  (**(code **)((ulonglong)*(uint *)(iVar3 + 0x2d0) * 4))
		            (piVar2,uVar1,*(undefined4 *)(iVar3 + 0x2d4));
		  return;
		}
		*/

		}

		// Token: 0x06000C7B RID: 3195 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C7B")]
		[Address(RVA = "0x5F7F", Offset = "0x5F7F", VA = "0x5F7F")]
		public void SetCounter(int currentValue, int totalValue)
		{
		/* --- GHIDRA: SetCounter ---
		void UI_Filters_FiltersView__SetCounter(int param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  int param1_00;
		  int iVar2;
		  int iVar3;
		  int iVar4;
		  int iVar5;
		  undefined4 param2_00;
		  uint uVar6;
		  
		  iVar2 = 0;
		  if (DAT_ram_00a63922 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_FilterInfo_FilterType__FilterInfo__get_Item__
		              );
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_int__Add__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_int___ctor__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_int__get_Count__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_List_int__TypeInfo);
		    DAT_ram_00a63922 = '\x01';
		  }
		  Gameplay_Medals_View_FilterButton__get_Selected(param2,(uint)(*(char *)(param2 + 0x24) == '\0'),0)
		  ;
		  param1_00 = unnamed_function_1417(System_Collections_Generic_List_int__TypeInfo);
		  GAFInternal_Objects_GAFBakedObjectImpl__get_isVisible
		            (param1_00,Method_System_Collections_Generic_List_int___ctor__);
		  iVar3 = *(int *)(param1 + 0x28);
		  iVar4 = *(int *)(iVar3 + 0xc);
		  if (0 < iVar4) {
		    do {
		      iVar1 = Method_System_Collections_Generic_List_int__Add__;
		      iVar5 = *(int *)(iVar3 + iVar2 * 4 + 0x10);
		      if (*(char *)(*(int *)(iVar5 + 0xc) + 0x24) != '\0') {
		        param2_00 = *(undefined4 *)(iVar5 + 8);
		        *(int *)(param1_00 + 0x10) = *(int *)(param1_00 + 0x10) + 1;
		        uVar6 = *(uint *)(param1_00 + 0xc);
		        if (uVar6 < *(uint *)(*(int *)(param1_00 + 8) + 0xc)) {
		          *(uint *)(param1_00 + 0xc) = uVar6 + 1;
		          *(undefined4 *)(*(int *)(param1_00 + 8) + uVar6 * 4 + 0x10) = param2_00;
		        }
		        else {
		          System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		                    (param1_00,param2_00,
		                     *(undefined4 *)(*(int *)(*(int *)(iVar1 + 0x10) + 0x60) + 0x38));
		          iVar4 = *(int *)(iVar3 + 0xc);
		        }
		      }
		      iVar2 = iVar2 + 1;
		    } while (iVar2 < iVar4);
		  }
		  iVar2 = GAFInternal_Reader_GAFReader__OpenTag
		                    (*(undefined4 *)(param1 + 0x38),1,
		                     Method_System_Collections_Generic_Dictionary_FilterInfo_FilterType__FilterInfo__get_Item__
		                    );
		  *(bool *)(iVar2 + 0x10) = 0 < *(int *)(param1_00 + 0xc);
		  iVar2 = GAFInternal_Reader_GAFReader__OpenTag
		                    (*(undefined4 *)(param1 + 0x38),1,
		                     Method_System_Collections_Generic_Dictionary_FilterInfo_FilterType__FilterInfo__get_Item__
		                    );
		  *(int *)(iVar2 + 0xc) = param1_00;
		  iVar2 = *(int *)(param1 + 0x30);
		  if (iVar2 != 0) {
		    (**(code **)((ulonglong)*(uint *)(iVar2 + 0xc) * 4))
		              (*(undefined4 *)(iVar2 + 0x20),*(undefined4 *)(iVar2 + 0x14));
		  }
		  return;
		}
		*/

		}

		// Token: 0x06000C7C RID: 3196 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C7C")]
		[Address(RVA = "0x5F80", Offset = "0x5F80", VA = "0x5F80")]
		private void ButtonOnClickEvent(FilterButton filterButton)
		{
		/* --- GHIDRA: ButtonOnClickEvent ---
		void UI_Filters_FiltersView__ButtonOnClickEvent(int param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  
		  if (DAT_ram_00a63923 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_FilterInfo_FilterType__FilterInfo__get_Item__
		              );
		    DAT_ram_00a63923 = '\x01';
		  }
		  Gameplay_Medals_View_FilterButton__get_Selected(param2,(uint)(*(char *)(param2 + 0x24) == '\0'),0)
		  ;
		  iVar1 = GAFInternal_Reader_GAFReader__OpenTag
		                    (*(undefined4 *)(param1 + 0x38),2,
		                     Method_System_Collections_Generic_Dictionary_FilterInfo_FilterType__FilterInfo__get_Item__
		                    );
		  *(undefined1 *)(iVar1 + 0x10) = *(undefined1 *)(param2 + 0x24);
		  iVar1 = *(int *)(param1 + 0x30);
		  if (iVar1 != 0) {
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		              (*(undefined4 *)(iVar1 + 0x20),*(undefined4 *)(iVar1 + 0x14));
		  }
		  return;
		}
		*/

		}

		// Token: 0x06000C7D RID: 3197 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C7D")]
		[Address(RVA = "0x5F81", Offset = "0x5F81", VA = "0x5F81")]
		private void OtherFilterButtonOnClickEvent(FilterButton filterButton)
		{
		/* --- GHIDRA: OtherFilterButtonOnClickEvent ---
		void UI_Filters_FiltersView__OtherFilterButtonOnClickEvent(int param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  
		  if (DAT_ram_00a63924 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_FilterInfo_FilterType__FilterInfo__get_Item__
		              );
		    DAT_ram_00a63924 = '\x01';
		  }
		  Gameplay_Medals_View_FilterButton__get_Selected(param2,(uint)(*(char *)(param2 + 0x24) == '\0'),0)
		  ;
		  iVar1 = GAFInternal_Reader_GAFReader__OpenTag
		                    (*(undefined4 *)(param1 + 0x38),3,
		                     Method_System_Collections_Generic_Dictionary_FilterInfo_FilterType__FilterInfo__get_Item__
		                    );
		  *(undefined1 *)(iVar1 + 0x10) = *(undefined1 *)(param2 + 0x24);
		  iVar1 = *(int *)(param1 + 0x30);
		  if (iVar1 != 0) {
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		              (*(undefined4 *)(iVar1 + 0x20),*(undefined4 *)(iVar1 + 0x14));
		  }
		  return;
		}
		*/

		}

		// Token: 0x06000C7E RID: 3198 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C7E")]
		[Address(RVA = "0x5F82", Offset = "0x5F82", VA = "0x5F82")]
		private void PriceFilterButtonOnClickEvent(FilterButton filterButton)
		{
		/* --- GHIDRA: PriceFilterButtonOnClickEvent ---
		void UI_Filters_FiltersView__PriceFilterButtonOnClickEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  
		  if (DAT_ram_00a63925 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_FilterInfo_FilterType__FilterInfo__get_Item__
		              );
		    DAT_ram_00a63925 = '\x01';
		  }
		  iVar1 = GAFInternal_Reader_GAFReader__OpenTag
		                    (*(undefined4 *)(param1 + 0x38),4,
		                     Method_System_Collections_Generic_Dictionary_FilterInfo_FilterType__FilterInfo__get_Item__
		                    );
		  uVar2 = func_ii_7457(*(undefined4 *)(param1 + 0x14),0);
		  uVar2 = Newtonsoft_Json_Serialization_JsonSerializerInternalReader__ShouldDeserialize(uVar2,0);
		  *(byte *)(iVar1 + 0x10) = (byte)uVar2 ^ 1;
		  iVar1 = GAFInternal_Reader_GAFReader__OpenTag
		                    (*(undefined4 *)(param1 + 0x38),4,
		                     Method_System_Collections_Generic_Dictionary_FilterInfo_FilterType__FilterInfo__get_Item__
		                    );
		  uVar2 = func_ii_7457(*(undefined4 *)(param1 + 0x14),0);
		  *(undefined4 *)(iVar1 + 0xc) = uVar2;
		  iVar1 = *(int *)(param1 + 0x30);
		  if (iVar1 != 0) {
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		              (*(undefined4 *)(iVar1 + 0x20),*(undefined4 *)(iVar1 + 0x14));
		  }
		  return;
		}
		*/

		}

		// Token: 0x06000C7F RID: 3199 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C7F")]
		[Address(RVA = "0x5F83", Offset = "0x5F83", VA = "0x5F83")]
		private void SearchInputChangedHandler(string value)
		{
		/* --- GHIDRA: SearchInputChangedHandler ---
		void UI_Filters_FiltersView__SearchInputChangedHandler(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  if (DAT_ram_00a63926 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_FilterInfo_FilterType__FilterInfo__get_Item__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_ArtikulTypeFilters__get_Count__);
		    DAT_ram_00a63926 = '\x01';
		  }
		  iVar1 = GAFInternal_Reader_GAFReader__OpenTag
		                    (*(undefined4 *)(param1 + 0x38),6,
		                     Method_System_Collections_Generic_Dictionary_FilterInfo_FilterType__FilterInfo__get_Item__
		                    );
		  *(bool *)(iVar1 + 0x10) = 0 < *(int *)(*(int *)(*(int *)(param1 + 0x24) + 0x18) + 0xc);
		  iVar1 = GAFInternal_Reader_GAFReader__OpenTag
		                    (*(undefined4 *)(param1 + 0x38),6,
		                     Method_System_Collections_Generic_Dictionary_FilterInfo_FilterType__FilterInfo__get_Item__
		                    );
		  *(undefined4 *)(iVar1 + 0xc) = *(undefined4 *)(*(int *)(param1 + 0x24) + 0x18);
		  iVar1 = *(int *)(param1 + 0x30);
		  if (iVar1 != 0) {
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		              (*(undefined4 *)(iVar1 + 0x20),*(undefined4 *)(iVar1 + 0x14));
		  }
		  return;
		}
		*/

		}

		// Token: 0x06000C80 RID: 3200 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C80")]
		[Address(RVA = "0x5F84", Offset = "0x5F84", VA = "0x5F84")]
		private void CraftFilterViewChangedEventHandler()
		{
		/* --- GHIDRA: CraftFilterViewChangedEventHandler ---
		void UI_Filters_FiltersView__CraftFilterViewChangedEventHandler(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  undefined4 uVar2;
		  int iVar3;
		  int iVar4;
		  
		  iVar4 = 0;
		  if (DAT_ram_00a63927 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_string__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_FilterButton__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_UI_Filters_FiltersView_AchievedToggleOnChangedEvent__);
		    Mono_Security_ASN1__get_Item(&Method_UI_Filters_FiltersView_ButtonOnClickEvent__);
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_Filters_FiltersView_CraftFilterViewChangedEventHandler__);
		    Mono_Security_ASN1__get_Item(&Method_UI_Filters_FiltersView_OtherFilterButtonOnClickEvent__);
		    Mono_Security_ASN1__get_Item(&Method_UI_Filters_FiltersView_PriceFilterButtonOnClickEvent__);
		    Mono_Security_ASN1__get_Item(&Method_UI_Filters_FiltersView_SearchInputChangedHandler__);
		    DAT_ram_00a63927 = '\x01';
		  }
		  uVar2 = *(undefined4 *)(param1 + 0x14);
		  uVar1 = unnamed_function_1417(System_Action_string__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar1,param1,Method_UI_Filters_FiltersView_SearchInputChangedHandler__,0);
		  UI_SearchInput__add_InputChangedEvent(uVar2,uVar1,0);
		  uVar2 = *(undefined4 *)(param1 + 0x18);
		  uVar1 = unnamed_function_1417(System_Action_FilterButton__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar1,param1,Method_UI_Filters_FiltersView_PriceFilterButtonOnClickEvent__,0);
		  Gameplay_Medals_View_FilterButton__add_ClickEvent(uVar2,uVar1,0);
		  uVar2 = *(undefined4 *)(param1 + 0x1c);
		  uVar1 = unnamed_function_1417(System_Action_FilterButton__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar1,param1,Method_UI_Filters_FiltersView_OtherFilterButtonOnClickEvent__,0);
		  Gameplay_Medals_View_FilterButton__add_ClickEvent(uVar2,uVar1,0);
		  uVar2 = *(undefined4 *)(param1 + 0x20);
		  uVar1 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (uVar1,param1,Method_UI_Filters_FiltersView_AchievedToggleOnChangedEvent__,0);
		  UI_Toggle_GreenToggle__add_ChangedEvent(uVar2,uVar1,0);
		  uVar2 = *(undefined4 *)(param1 + 0x24);
		  uVar1 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (uVar1,param1,Method_UI_Filters_FiltersView_CraftFilterViewChangedEventHandler__,0);
		  Gameplay_Craft_View_CraftFiltersView__add_ChangedEvent(uVar2,uVar1,0);
		  iVar3 = *(int *)(param1 + 0x28);
		  if (0 < *(int *)(iVar3 + 0xc)) {
		    do {
		      uVar2 = *(undefined4 *)(*(int *)(iVar3 + iVar4 * 4 + 0x10) + 0xc);
		      uVar1 = unnamed_function_1417(System_Action_FilterButton__TypeInfo);
		      UnityEngine_UIElements_VisualElement__get_layout
		                (uVar1,param1,Method_UI_Filters_FiltersView_ButtonOnClickEvent__,0);
		      Gameplay_Medals_View_FilterButton__add_ClickEvent(uVar2,uVar1,0);
		      iVar4 = iVar4 + 1;
		    } while (iVar4 < *(int *)(iVar3 + 0xc));
		  }
		  return;
		}
		*/

		}

		// Token: 0x06000C81 RID: 3201 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C81")]
		[Address(RVA = "0x5F85", Offset = "0x5F85", VA = "0x5F85")]
		private void OnDestroy()
		{
		}

		// Token: 0x06000C82 RID: 3202 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C82")]
		[Address(RVA = "0x5F86", Offset = "0x5F86", VA = "0x5F86")]
		public FiltersView()
		{
		/* --- GHIDRA: .ctor ---
		void UI_Filters_FiltersView___ctor(undefined4 param1)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a63928 == '\0') {
		    Mono_Security_ASN1__get_Item(&UI_Filters_FiltersView___c_TypeInfo);
		    DAT_ram_00a63928 = '\x01';
		  }
		  uVar1 = unnamed_function_1417(UI_Filters_FiltersView___c_TypeInfo);
		  **(undefined4 **)(UI_Filters_FiltersView___c_TypeInfo + 0x5c) = uVar1;
		  return;
		}
		*/

		}

		// Token: 0x04000605 RID: 1541
		[Token(Token = "0x4000605")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private bool _useCraftFilters;

		// Token: 0x04000606 RID: 1542
		[Token(Token = "0x4000606")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private SearchInput _searchInput;

		// Token: 0x04000607 RID: 1543
		[Token(Token = "0x4000607")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private FilterButton _priceFilterButton;

		// Token: 0x04000608 RID: 1544
		[Token(Token = "0x4000608")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private FilterButton _otherFilterButton;

		// Token: 0x04000609 RID: 1545
		[Token(Token = "0x4000609")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GreenToggle _achievedToggle;

		// Token: 0x0400060A RID: 1546
		[Token(Token = "0x400060A")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private CraftFiltersView _craftFilters;

		// Token: 0x0400060B RID: 1547
		[Token(Token = "0x400060B")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private SkillFilterButtonData[] _skillButtons;

		// Token: 0x0400060C RID: 1548
		[Token(Token = "0x400060C")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private TextMeshProUGUI _countLabel;

		// Token: 0x0400060E RID: 1550
		[Token(Token = "0x400060E")]
		[FieldOffset(Offset = "0x34")]
		private List<FilterInfo> _filtersInfo;

		// Token: 0x0400060F RID: 1551
		[Token(Token = "0x400060F")]
		[FieldOffset(Offset = "0x38")]
		private Dictionary<FilterInfo.FilterType, FilterInfo> _filtersInfoDictionary;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_PriceFilterButton ---
		void UI_Filters_FiltersView__get_PriceFilterButton(int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  int param1_00;
		  int *param1_01;
		  int iVar2;
		  
		  if (DAT_ram_00a6391d == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    DAT_ram_00a6391d = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x30);
		  while ((param1_01 = (int *)UnityEngine_UI_Image__set_sprite(param1_00,param2,0),
		         param1_01 == (int *)0x0 || (System_Action_TypeInfo == *param1_01))) {
		    iVar2 = func_ii_4329(param1 + 0x30,param1_01,param1_00);
		    bVar1 = iVar2 == param1_00;
		    param1_00 = iVar2;
		    if (bVar1) {
		      return;
		    }
		  }
		  System_Activator__CreateInstance(param1_01,System_Action_TypeInfo);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/


		/* --- GHIDRA: add_ChangedEvent ---
		void UI_Filters_FiltersView__add_ChangedEvent(int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  int param1_00;
		  int *param1_01;
		  int iVar2;
		  
		  if (DAT_ram_00a6391e == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    DAT_ram_00a6391e = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x30);
		  while ((param1_01 = (int *)func_ii_7048(param1_00,param2,0), param1_01 == (int *)0x0 ||
		         (System_Action_TypeInfo == *param1_01))) {
		    iVar2 = func_ii_4329(param1 + 0x30,param1_01,param1_00);
		    bVar1 = iVar2 == param1_00;
		    param1_00 = iVar2;
		    if (bVar1) {
		      return;
		    }
		  }
		  System_Activator__CreateInstance(param1_01,System_Action_TypeInfo);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/


		/* --- GHIDRA: get_FiltersInfoDictionary ---
		undefined4 UI_Filters_FiltersView__get_FiltersInfoDictionary(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  
		  uVar1 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (*(undefined4 *)(param1 + 0x20),0);
		  return uVar1;
		}
		*/


		/* --- GHIDRA: get_AchievedToggle ---
		void UI_Filters_FiltersView__get_AchievedToggle(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  undefined4 uVar3;
		  int iVar4;
		  int iVar5;
		  uint uVar6;
		  undefined4 *puVar7;
		  
		  iVar1 = 0;
		  if (DAT_ram_00a6391f == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_string__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_FilterButton__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Linq_Enumerable_ToDictionary_FilterInfo__FilterInfo_FilterType___);
		    Mono_Security_ASN1__get_Item(&UI_Filters_FilterInfo_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_UI_Filters_FiltersView_AchievedToggleOnChangedEvent__);
		    Mono_Security_ASN1__get_Item(&Method_UI_Filters_FiltersView_ButtonOnClickEvent__);
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_Filters_FiltersView_CraftFilterViewChangedEventHandler__);
		    Mono_Security_ASN1__get_Item(&Method_UI_Filters_FiltersView_OtherFilterButtonOnClickEvent__);
		    Mono_Security_ASN1__get_Item(&Method_UI_Filters_FiltersView_PriceFilterButtonOnClickEvent__);
		    Mono_Security_ASN1__get_Item(&Method_UI_Filters_FiltersView_SearchInputChangedHandler__);
		    Mono_Security_ASN1__get_Item(&System_Func_FilterInfo__FilterInfo_FilterType__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_FilterInfo__Add__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_FilterInfo___ctor__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_List_FilterInfo__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_UI_Filters_FiltersView___c__Awake_b__21_0__);
		    Mono_Security_ASN1__get_Item(&UI_Filters_FiltersView___c_TypeInfo);
		    DAT_ram_00a6391f = '\x01';
		  }
		  uVar3 = *(undefined4 *)(param1 + 0x14);
		  uVar2 = unnamed_function_1417(System_Action_string__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,Method_UI_Filters_FiltersView_SearchInputChangedHandler__,0);
		  UI_NumbersInput___ctor(uVar3,uVar2,0);
		  uVar3 = *(undefined4 *)(param1 + 0x18);
		  uVar2 = unnamed_function_1417(System_Action_FilterButton__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,Method_UI_Filters_FiltersView_PriceFilterButtonOnClickEvent__,0);
		  Gameplay_Medals_View_MedalsWindowArgs___ctor(uVar3,uVar2,0);
		  uVar3 = *(undefined4 *)(param1 + 0x1c);
		  uVar2 = unnamed_function_1417(System_Action_FilterButton__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,Method_UI_Filters_FiltersView_OtherFilterButtonOnClickEvent__,0);
		  Gameplay_Medals_View_MedalsWindowArgs___ctor(uVar3,uVar2,0);
		  uVar3 = *(undefined4 *)(param1 + 0x20);
		  uVar2 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (uVar2,param1,Method_UI_Filters_FiltersView_AchievedToggleOnChangedEvent__,0);
		  UI_ToolTip_Controller_Android_ToolTipController__GetPointerPosition(uVar3,uVar2,0);
		  uVar3 = *(undefined4 *)(param1 + 0x24);
		  uVar2 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (uVar2,param1,Method_UI_Filters_FiltersView_CraftFilterViewChangedEventHandler__,0);
		  Gameplay_Discounts_Controller_DiscountsViewMediator___c___DiscountsRequestedEventHandler_b__5_0
		            (uVar3,uVar2,0);
		  iVar4 = *(int *)(param1 + 0x28);
		  if (0 < *(int *)(iVar4 + 0xc)) {
		    do {
		      uVar3 = *(undefined4 *)(*(int *)(iVar4 + iVar1 * 4 + 0x10) + 0xc);
		      uVar2 = unnamed_function_1417(System_Action_FilterButton__TypeInfo);
		      UnityEngine_UIElements_VisualElement__get_layout
		                (uVar2,param1,Method_UI_Filters_FiltersView_ButtonOnClickEvent__,0);
		      Gameplay_Medals_View_MedalsWindowArgs___ctor(uVar3,uVar2,0);
		      iVar1 = iVar1 + 1;
		    } while (iVar1 < *(int *)(iVar4 + 0xc));
		  }
		  uVar2 = unnamed_function_1417(System_Collections_Generic_List_FilterInfo__TypeInfo);
		  GAFInternal_Objects_GAFBakedObjectImpl__get_isVisible
		            (uVar2,Method_System_Collections_Generic_List_FilterInfo___ctor__);
		  *(undefined4 *)(param1 + 0x34) = uVar2;
		  iVar4 = unnamed_function_1417(UI_Filters_FilterInfo_TypeInfo);
		  *(undefined4 *)(iVar4 + 8) = 1;
		  iVar1 = Method_System_Collections_Generic_List_FilterInfo__Add__;
		  iVar5 = *(int *)(param1 + 0x34);
		  *(int *)(iVar5 + 0x10) = *(int *)(iVar5 + 0x10) + 1;
		  uVar6 = *(uint *)(iVar5 + 0xc);
		  if (uVar6 < *(uint *)(*(int *)(iVar5 + 8) + 0xc)) {
		    *(uint *)(iVar5 + 0xc) = uVar6 + 1;
		    *(int *)(*(int *)(iVar5 + 8) + uVar6 * 4 + 0x10) = iVar4;
		  }
		  else {
		    System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		              (iVar5,iVar4,*(undefined4 *)(*(int *)(*(int *)(iVar1 + 0x10) + 0x60) + 0x38));
		  }
		  iVar4 = unnamed_function_1417(UI_Filters_FilterInfo_TypeInfo);
		  *(undefined4 *)(iVar4 + 8) = 2;
		  iVar1 = Method_System_Collections_Generic_List_FilterInfo__Add__;
		  iVar5 = *(int *)(param1 + 0x34);
		  *(int *)(iVar5 + 0x10) = *(int *)(iVar5 + 0x10) + 1;
		  uVar6 = *(uint *)(iVar5 + 0xc);
		  if (uVar6 < *(uint *)(*(int *)(iVar5 + 8) + 0xc)) {
		    *(uint *)(iVar5 + 0xc) = uVar6 + 1;
		    *(int *)(*(int *)(iVar5 + 8) + uVar6 * 4 + 0x10) = iVar4;
		  }
		  else {
		    System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		              (iVar5,iVar4,*(undefined4 *)(*(int *)(*(int *)(iVar1 + 0x10) + 0x60) + 0x38));
		  }
		  iVar4 = unnamed_function_1417(UI_Filters_FilterInfo_TypeInfo);
		  *(undefined4 *)(iVar4 + 8) = 3;
		  iVar1 = Method_System_Collections_Generic_List_FilterInfo__Add__;
		  iVar5 = *(int *)(param1 + 0x34);
		  *(int *)(iVar5 + 0x10) = *(int *)(iVar5 + 0x10) + 1;
		  uVar6 = *(uint *)(iVar5 + 0xc);
		  if (uVar6 < *(uint *)(*(int *)(iVar5 + 8) + 0xc)) {
		    *(uint *)(iVar5 + 0xc) = uVar6 + 1;
		    *(int *)(*(int *)(iVar5 + 8) + uVar6 * 4 + 0x10) = iVar4;
		  }
		  else {
		    System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		              (iVar5,iVar4,*(undefined4 *)(*(int *)(*(int *)(iVar1 + 0x10) + 0x60) + 0x38));
		  }
		  iVar4 = unnamed_function_1417(UI_Filters_FilterInfo_TypeInfo);
		  *(undefined4 *)(iVar4 + 8) = 4;
		  iVar1 = Method_System_Collections_Generic_List_FilterInfo__Add__;
		  iVar5 = *(int *)(param1 + 0x34);
		  *(int *)(iVar5 + 0x10) = *(int *)(iVar5 + 0x10) + 1;
		  uVar6 = *(uint *)(iVar5 + 0xc);
		  if (uVar6 < *(uint *)(*(int *)(iVar5 + 8) + 0xc)) {
		    *(uint *)(iVar5 + 0xc) = uVar6 + 1;
		    *(int *)(*(int *)(iVar5 + 8) + uVar6 * 4 + 0x10) = iVar4;
		  }
		  else {
		    System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		              (iVar5,iVar4,*(undefined4 *)(*(int *)(*(int *)(iVar1 + 0x10) + 0x60) + 0x38));
		  }
		  iVar4 = unnamed_function_1417(UI_Filters_FilterInfo_TypeInfo);
		  *(undefined4 *)(iVar4 + 8) = 5;
		  iVar1 = Method_System_Collections_Generic_List_FilterInfo__Add__;
		  iVar5 = *(int *)(param1 + 0x34);
		  *(int *)(iVar5 + 0x10) = *(int *)(iVar5 + 0x10) + 1;
		  uVar6 = *(uint *)(iVar5 + 0xc);
		  if (uVar6 < *(uint *)(*(int *)(iVar5 + 8) + 0xc)) {
		    *(uint *)(iVar5 + 0xc) = uVar6 + 1;
		    *(int *)(*(int *)(iVar5 + 8) + uVar6 * 4 + 0x10) = iVar4;
		  }
		  else {
		    System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		              (iVar5,iVar4,*(undefined4 *)(*(int *)(*(int *)(iVar1 + 0x10) + 0x60) + 0x38));
		  }
		  iVar4 = unnamed_function_1417(UI_Filters_FilterInfo_TypeInfo);
		  *(undefined4 *)(iVar4 + 8) = 6;
		  iVar1 = Method_System_Collections_Generic_List_FilterInfo__Add__;
		  iVar5 = *(int *)(param1 + 0x34);
		  *(int *)(iVar5 + 0x10) = *(int *)(iVar5 + 0x10) + 1;
		  uVar6 = *(uint *)(iVar5 + 0xc);
		  if (uVar6 < *(uint *)(*(int *)(iVar5 + 8) + 0xc)) {
		    *(uint *)(iVar5 + 0xc) = uVar6 + 1;
		    *(int *)(*(int *)(iVar5 + 8) + uVar6 * 4 + 0x10) = iVar4;
		  }
		  else {
		    System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		              (iVar5,iVar4,*(undefined4 *)(*(int *)(*(int *)(iVar1 + 0x10) + 0x60) + 0x38));
		  }
		  uVar2 = *(undefined4 *)(param1 + 0x34);
		  if (*(int *)(UI_Filters_FiltersView___c_TypeInfo + 0x74) == 0) {
		    func_ii_306000(UI_Filters_FiltersView___c_TypeInfo);
		  }
		  puVar7 = *(undefined4 **)(UI_Filters_FiltersView___c_TypeInfo + 0x5c);
		  iVar1 = puVar7[1];
		  if (iVar1 == 0) {
		    if (*(int *)(UI_Filters_FiltersView___c_TypeInfo + 0x74) == 0) {
		      func_ii_306000(UI_Filters_FiltersView___c_TypeInfo);
		      puVar7 = *(undefined4 **)(UI_Filters_FiltersView___c_TypeInfo + 0x5c);
		    }
		    uVar3 = *puVar7;
		    iVar1 = unnamed_function_1417(System_Func_FilterInfo__FilterInfo_FilterType__TypeInfo);
		    System_Action_object____ctor(iVar1,uVar3,Method_UI_Filters_FiltersView___c__Awake_b__21_0__,0);
		    *(int *)(*(int *)(UI_Filters_FiltersView___c_TypeInfo + 0x5c) + 4) = iVar1;
		  }
		  uVar2 = System_Linq_Enumerable__ToArray_InputControlScheme_DeviceRequirement_
		                    (uVar2,iVar1,
		                     Method_System_Linq_Enumerable_ToDictionary_FilterInfo__FilterInfo_FilterType___
		                    );
		  *(undefined4 *)(param1 + 0x38) = uVar2;
		  if (*(char *)(param1 + 0x10) != '\0') {
		    Gameplay_Craft_View_CraftFiltersView__remove_ChangedEvent(*(undefined4 *)(param1 + 0x24),0);
		  }
		  return;
		}
		*/

}
