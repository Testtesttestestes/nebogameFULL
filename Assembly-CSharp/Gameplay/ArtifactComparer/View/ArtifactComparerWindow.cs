using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Core.Data;
using Gameplay.ArtifactComparer.Controller;
using Gameplay.ArtifactComparer.Model;
using Gameplay.ArtifactComparer.View.SkillSelector;
using Il2CppDummyDll;
using Protocol.Dic;
using TMPro;
using UI;
using UI.Filters;
using UI.Windows;
using UnityEngine;
using Utils.Cache;

namespace Gameplay.ArtifactComparer.View
{
	// Token: 0x02000CD9 RID: 3289
	[Token(Token = "0x2000CD9")]
	public class ArtifactComparerWindow : ClosableBaseWindow<ArtifactComparerWindow.ArtifactComparerWindowArgs>
	{
		// Token: 0x1700102E RID: 4142
		// (get) Token: 0x06004FFE RID: 20478 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700102E")]
		public override string WindowId
		{
			[Token(Token = "0x6004FFE")]
			[Address(RVA = "0x9E12", Offset = "0x9E12", VA = "0x9E12", Slot = "14")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700102F RID: 4143
		// (get) Token: 0x06004FFF RID: 20479 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700102F")]
		public ToggleButton SkillSelectorButton
		{
			[Token(Token = "0x6004FFF")]
			[Address(RVA = "0x9E13", Offset = "0x9E13", VA = "0x9E13")]
			get
			{
				return null;
			}
		}

		// Token: 0x17001030 RID: 4144
		// (get) Token: 0x06005000 RID: 20480 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17001030")]
		public SkillSelectorView SkillSelectorView
		{
			[Token(Token = "0x6005000")]
			[Address(RVA = "0x9E14", Offset = "0x9E14", VA = "0x9E14")]
			get
			{
				return null;
			}
		}

		// Token: 0x17001031 RID: 4145
		// (get) Token: 0x06005001 RID: 20481 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17001031")]
		public FiltersView FiltersView
		{
			[Token(Token = "0x6005001")]
			[Address(RVA = "0x9E15", Offset = "0x9E15", VA = "0x9E15")]
			get
			{
				return null;
			}
		}

		// Token: 0x17001032 RID: 4146
		// (get) Token: 0x06005002 RID: 20482 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17001032")]
		public ArtifactComparerPowerBars PowerBars
		{
			[Token(Token = "0x6005002")]
			[Address(RVA = "0x9E16", Offset = "0x9E16", VA = "0x9E16")]
			get
			{
				return null;
			}
		}

		// Token: 0x17001033 RID: 4147
		// (get) Token: 0x06005003 RID: 20483 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17001033")]
		public TextMeshProUGUI SlotTitle
		{
			[Token(Token = "0x6005003")]
			[Address(RVA = "0x9E17", Offset = "0x9E17", VA = "0x9E17")]
			get
			{
				return null;
			}
		}

		// Token: 0x17001034 RID: 4148
		// (get) Token: 0x06005004 RID: 20484 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17001034")]
		public ArtifactComparerItemView LeftComparerView
		{
			[Token(Token = "0x6005004")]
			[Address(RVA = "0x9E18", Offset = "0x9E18", VA = "0x9E18")]
			get
			{
				return null;
			}
		}

		// Token: 0x17001035 RID: 4149
		// (get) Token: 0x06005005 RID: 20485 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17001035")]
		public ArtifactComparerItemView RightComparerView
		{
			[Token(Token = "0x6005005")]
			[Address(RVA = "0x9E19", Offset = "0x9E19", VA = "0x9E19")]
			get
			{
				return null;
			}
		}

		// Token: 0x17001036 RID: 4150
		// (get) Token: 0x06005006 RID: 20486 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17001036")]
		public ArtifactComparerTable Table
		{
			[Token(Token = "0x6005006")]
			[Address(RVA = "0x9E1A", Offset = "0x9E1A", VA = "0x9E1A")]
			get
			{
				return null;
			}
		}

		// Token: 0x140001E4 RID: 484
		// (add) Token: 0x06005007 RID: 20487 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06005008 RID: 20488 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140001E4")]
		public event Action<ArtifactData> SelectArtifactEvent
		{
			[Token(Token = "0x6005007")]
			[Address(RVA = "0x9E1B", Offset = "0x9E1B", VA = "0x9E1B")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6005008")]
			[Address(RVA = "0x9E1C", Offset = "0x9E1C", VA = "0x9E1C")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x140001E5 RID: 485
		// (add) Token: 0x06005009 RID: 20489 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x0600500A RID: 20490 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140001E5")]
		public event Action<ArtifactComparerWindow.ArtifactComparerWindowArgs> NewDataEvent
		{
			[Token(Token = "0x6005009")]
			[Address(RVA = "0x9E1D", Offset = "0x9E1D", VA = "0x9E1D")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600500A")]
			[Address(RVA = "0x9E1E", Offset = "0x9E1E", VA = "0x9E1E")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x0600500B RID: 20491 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600500B")]
		[Address(RVA = "0x9E1F", Offset = "0x9E1F", VA = "0x9E1F", Slot = "24")]
		protected override void Awake()
		{
		/* --- GHIDRA: Awake ---
		void Gameplay_ArtifactComparer_View_ArtifactComparerWindow__Awake
		               (undefined4 param1,int param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int iVar2;
		  undefined4 uVar3;
		  int param1_00;
		  int iVar4;
		  
		  if (DAT_ram_00a58a0f == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ArtifactData__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_ArtifactComparer_View_ArtifactComparerWindow_ViewOnClickEvent__);
		    DAT_ram_00a58a0f = '\x01';
		  }
		  uVar3 = unnamed_function_1417(System_Action_ArtifactData__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar3,param1,
		             Method_Gameplay_ArtifactComparer_View_ArtifactComparerWindow_ViewOnClickEvent__,0);
		  if (DAT_ram_00a58a19 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ArtifactData__TypeInfo);
		    DAT_ram_00a58a19 = '\x01';
		  }
		  iVar4 = *(int *)(param2 + 0x28);
		  while( true ) {
		    iVar2 = 0;
		    param1_00 = func_ii_7048(iVar4,uVar3,0);
		    param2_00 = System_Action_ArtifactData__TypeInfo;
		    if ((param1_00 != 0) &&
		       (iVar2 = func_ii_1082(param1_00,System_Action_ArtifactData__TypeInfo), iVar2 == 0)) break;
		    iVar2 = func_ii_4329(param2 + 0x28,iVar2,iVar4);
		    bVar1 = iVar2 == iVar4;
		    iVar4 = iVar2;
		    if (bVar1) {
		      *(undefined4 *)(param2 + 0x24) = 0;
		      iVar4 = **(int **)(param2 + 0x10);
		      (**(code **)((ulonglong)*(uint *)(iVar4 + 0x2d0) * 4))
		                (*(int **)(param2 + 0x10),0,*(undefined4 *)(iVar4 + 0x2d4));
		      *(undefined4 *)(param2 + 0x2c) = 0;
		      Core_Extensions_Dict_ArtikulTypeDicExt__GetTitle(param2,iVar4);
		      uVar3 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                        (param2,0);
		      Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		                (uVar3,0,0);
		      return;
		    }
		  }
		  System_Activator__CreateInstance(param1_00,param2_00);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}

		// Token: 0x0600500C RID: 20492 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600500C")]
		[Address(RVA = "0x9E20", Offset = "0x9E20", VA = "0x9E20")]
		private void OnReleasePooledObject(PossibleArtifactsGroupView pooledObject)
		{
		/* --- GHIDRA: OnReleasePooledObject ---
		void Gameplay_ArtifactComparer_View_ArtifactComparerWindow__OnReleasePooledObject
		               (undefined4 param1,undefined4 param2,undefined4 param3)
		
		{
		  if (DAT_ram_00a58a10 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_ClosableBaseWindow_ArtifactComparerWindow_ArtifactComparerWindowArgs__OnShow__
		              );
		    DAT_ram_00a58a10 = '\x01';
		  }
		  func_ii_7769(param1,param2,
		               Method_UI_Windows_ClosableBaseWindow_ArtifactComparerWindow_ArtifactComparerWindowArgs__OnShow__
		              );
		  Gameplay_ArtifactComparer_View_ArtifactComparerWindow__OnShow(param1,param1);
		  return;
		}
		*/

		}

		// Token: 0x0600500D RID: 20493 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600500D")]
		[Address(RVA = "0x9E21", Offset = "0x9E21", VA = "0x9E21", Slot = "22")]
		protected override void OnShow(ArtifactComparerWindow.ArtifactComparerWindowArgs args)
		{
		/* --- GHIDRA: OnShow ---
		void Gameplay_ArtifactComparer_View_ArtifactComparerWindow__OnShow(int param1,undefined4 param2)
		
		{
		  byte bVar1;
		  int iVar2;
		  int *param1_00;
		  undefined4 param2_00;
		  undefined4 param3;
		  undefined4 param4;
		  
		  if (DAT_ram_00a58a11 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_ArtifactComparer_Controller_ArtifactComparerWindowMediator_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_BaseWindow_ArtifactComparerWindow_ArtifactComparerWindowArgs__get_WindowArgs__
		              );
		    Mono_Security_ASN1__get_Item(&OKG_Logs_Debug_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_3290);
		    DAT_ram_00a58a11 = '\x01';
		  }
		  if (*(int *)(param1 + 0x70) != 0) {
		    if (*(int *)(OKG_Logs_Debug_TypeInfo + 0x74) == 0) {
		      func_ii_306000(OKG_Logs_Debug_TypeInfo);
		    }
		    func_ii_7830(StringLiteral_3290,0);
		    return;
		  }
		  iVar2 = func_ii_8093(param1,
		                       Method_UI_Windows_BaseWindow_ArtifactComparerWindow_ArtifactComparerWindowArgs__get_WindowArgs__
		                      );
		  *(undefined4 *)(param1 + 0x6c) = *(undefined4 *)(iVar2 + 0x1c);
		  iVar2 = func_ii_8093(param1,
		                       Method_UI_Windows_BaseWindow_ArtifactComparerWindow_ArtifactComparerWindowArgs__get_WindowArgs__
		                      );
		  *(undefined4 *)(param1 + 0x70) = *(undefined4 *)(iVar2 + 0x24);
		  iVar2 = func_ii_8093(param1,
		                       Method_UI_Windows_BaseWindow_ArtifactComparerWindow_ArtifactComparerWindowArgs__get_WindowArgs__
		                      );
		  param4 = *(undefined4 *)(iVar2 + 0x20);
		  *(undefined4 *)(param1 + 0x74) = param4;
		  param2_00 = *(undefined4 *)(param1 + 0x70);
		  param3 = *(undefined4 *)(param1 + 0x6c);
		  iVar2 = func_ii_8093(param1,
		                       Method_UI_Windows_BaseWindow_ArtifactComparerWindow_ArtifactComparerWindowArgs__get_WindowArgs__
		                      );
		  bVar1 = *(byte *)(iVar2 + 0x28);
		  param1_00 = (int *)unnamed_function_1417
		                               (
		                               Gameplay_ArtifactComparer_Controller_ArtifactComparerWindowMediator_TypeInfo
		                               );
		  Gameplay_ArtifactComparer_Controller_ArtifactComparerEvents___ctor
		            (param1_00,param2_00,param3,param4,(uint)bVar1,param1);
		  *(int **)(param1 + 0x78) = param1_00;
		  (**(code **)((ulonglong)*(uint *)(*param1_00 + 0x160) * 4))
		            (param1_00,param1,*(undefined4 *)(*param1_00 + 0x164));
		  return;
		}
		*/

		}

		// Token: 0x0600500E RID: 20494 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600500E")]
		[Address(RVA = "0x9E22", Offset = "0x9E22", VA = "0x9E22")]
		private void InitMvc()
		{
		/* --- GHIDRA: InitMvc ---
		void Gameplay_ArtifactComparer_View_ArtifactComparerWindow__InitMvc
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  
		  iVar1 = *(int *)(param1 + 0x80);
		  if (iVar1 != 0) {
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		              (*(undefined4 *)(iVar1 + 0x20),param2,*(undefined4 *)(iVar1 + 0x14));
		  }
		  return;
		}
		*/

		}

		// Token: 0x0600500F RID: 20495 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600500F")]
		[Address(RVA = "0x9E23", Offset = "0x9E23", VA = "0x9E23")]
		public void SetNewData(ArtifactComparerWindow.ArtifactComparerWindowArgs newArgs)
		{
		/* --- GHIDRA: SetNewData ---
		void Gameplay_ArtifactComparer_View_ArtifactComparerWindow__SetNewData(int param1,undefined4 param2)
		
		{
		  int *piVar1;
		  
		  if (DAT_ram_00a58a12 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_ClosableBaseWindow_ArtifactComparerWindow_ArtifactComparerWindowArgs__OnClose__
		              );
		    DAT_ram_00a58a12 = '\x01';
		  }
		  UI_Windows_ClosableBaseWindow_object___OnClickBack
		            (param1,
		             Method_UI_Windows_ClosableBaseWindow_ArtifactComparerWindow_ArtifactComparerWindowArgs__OnClose__
		            );
		  *(undefined4 *)(param1 + 0x84) = 0;
		  Gameplay_ArtifactComparer_View_ArtifactComparerWindow__set_PossibleArtifacts(param1,param1);
		  piVar1 = *(int **)(param1 + 0x78);
		  if (piVar1 != (int *)0x0) {
		    (**(code **)((ulonglong)*(uint *)(*piVar1 + 0x130) * 4))
		              (piVar1,*(undefined4 *)(*piVar1 + 0x134));
		  }
		  *(undefined8 *)(param1 + 0x6c) = 0;
		  *(undefined8 *)(param1 + 0x74) = 0;
		  return;
		}
		*/

		}

		// Token: 0x06005010 RID: 20496 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005010")]
		[Address(RVA = "0x9E24", Offset = "0x9E24", VA = "0x9E24", Slot = "19")]
		protected override void OnClose()
		{
		/* --- GHIDRA: OnClose ---
		void Gameplay_ArtifactComparer_View_ArtifactComparerWindow__OnClose(int param1,undefined4 param2)
		
		{
		  int *piVar1;
		  
		  piVar1 = *(int **)(param1 + 0x78);
		  if (piVar1 != (int *)0x0) {
		    (**(code **)((ulonglong)*(uint *)(*piVar1 + 0x130) * 4))
		              (piVar1,*(undefined4 *)(*piVar1 + 0x134));
		  }
		  *(undefined8 *)(param1 + 0x6c) = 0;
		  *(undefined8 *)(param1 + 0x74) = 0;
		  return;
		}
		*/

		}

		// Token: 0x06005011 RID: 20497 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005011")]
		[Address(RVA = "0x9E25", Offset = "0x9E25", VA = "0x9E25")]
		private void DestroyMvc()
		{
		}

		// Token: 0x17001037 RID: 4151
		// (get) Token: 0x06005012 RID: 20498 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06005013 RID: 20499 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001037")]
		public Dictionary<ArtikulTypeDic, List<ArtifactData>> PossibleArtifacts
		{
			[Token(Token = "0x6005012")]
			[Address(RVA = "0x9E26", Offset = "0x9E26", VA = "0x9E26")]
			get
			{
				return null;
			}
			[Token(Token = "0x6005013")]
			[Address(RVA = "0x9E27", Offset = "0x9E27", VA = "0x9E27")]
			set
			{
			}
		}

		// Token: 0x06005014 RID: 20500 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005014")]
		[Address(RVA = "0x9E28", Offset = "0x9E28", VA = "0x9E28")]
		private void HandlePossibleArtifactsChanged()
		{
		/* --- GHIDRA: HandlePossibleArtifactsChanged ---
		void Gameplay_ArtifactComparer_View_ArtifactComparerWindow__HandlePossibleArtifactsChanged
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  
		  iVar1 = *(int *)(param1 + 0x7c);
		  if (iVar1 != 0) {
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		              (*(undefined4 *)(iVar1 + 0x20),param2,*(undefined4 *)(iVar1 + 0x14));
		  }
		  return;
		}
		*/

		}

		// Token: 0x06005015 RID: 20501 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005015")]
		[Address(RVA = "0x9E29", Offset = "0x9E29", VA = "0x9E29")]
		private void ViewOnClickEvent(ArtifactData artifactData)
		{
		/* --- GHIDRA: ViewOnClickEvent ---
		void Gameplay_ArtifactComparer_View_ArtifactComparerWindow__ViewOnClickEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  int iVar2;
		  undefined4 param1_00;
		  int *piVar3;
		  undefined1 auStack_20 [8];
		  int local_18;
		  undefined8 *local_14;
		  undefined8 local_10;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a58a14 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_List_Enumerator_PossibleArtifactsGroupView__Dispose__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_List_Enumerator_PossibleArtifactsGroupView__MoveNext__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_List_Enumerator_PossibleArtifactsGroupView__get_Current__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_PossibleArtifactsGroupView__GetEnumerator__);
		    DAT_ram_00a58a14 = '\x01';
		  }
		  local_8 = 0;
		  local_10 = 0;
		  System_Collections_Generic_List_RegexCharClass_SingleRange___ForEach
		            (&local_10,*(undefined4 *)(param1 + 0x68),
		             Method_System_Collections_Generic_List_PossibleArtifactsGroupView__GetEnumerator__);
		  local_18 = 0;
		  local_14 = &local_10;
		  do {
		    DAT_ram_009d3e38 = 0;
		    iVar2 = import::env::invoke_iii
		                      (s_struct_Uniforms___color__array<v_ram_00000aff + 0x44,&local_10,
		                       Method_System_Collections_Generic_List_Enumerator_PossibleArtifactsGroupView__MoveNext__
		                      );
		    iVar1 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar1 == 1) {
		      param1_00 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80f5f989;
		    }
		    if (iVar2 == 0) {
		      DAT_ram_009d3e38 = 0;
		      return;
		    }
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_viii
		              (s_struct_Uniforms___color__array<v_ram_00001b87 + 0x20d,local_8._4_4_,param2,
		               auStack_20);
		    iVar1 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		  } while (iVar1 != 1);
		  param1_00 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x80f5f989:
		  iVar1 = global_1;
		  iVar2 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		  if (iVar1 == iVar2) {
		    piVar3 = (int *)import::env::__cxa_begin_catch(param1_00);
		    iVar2 = *piVar3;
		    DAT_ram_009d3e38 = 0;
		    local_18 = iVar2;
		    import::env::invoke_v(0x123);
		    iVar1 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar1 != 1) {
		      if (iVar2 == 0) {
		        DAT_ram_009d3e38 = 0;
		        return;
		      }
		      System_Data_DataSet__ValidateLocaleConstraint(iVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    param1_00 = import::env::__cxa_find_matching_catch_2();
		  }
		  DAT_ram_009d3e38 = 0;
		  import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_00001b87 + 0x20e,&local_18);
		  iVar1 = DAT_ram_009d3e38;
		  DAT_ram_009d3e38 = 0;
		  if (iVar1 != 1) {
		    import::env::__resumeException(param1_00);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  import::env::__cxa_find_matching_catch_3(0);
		  unnamed_function_937();
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}

		// Token: 0x06005016 RID: 20502 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005016")]
		[Address(RVA = "0x9E2A", Offset = "0x9E2A", VA = "0x9E2A")]
		public void SelectComparableArtifact(ArtifactData comparableArtifact)
		{
		/* --- GHIDRA: SelectComparableArtifact ---
		void Gameplay_ArtifactComparer_View_ArtifactComparerWindow__SelectComparableArtifact
		               (int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a58a15 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_ClosableBaseWindow_ArtifactComparerWindow_ArtifactComparerWindowArgs___ctor__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_PossibleArtifactsGroupView___ctor__);
		    Mono_Security_ASN1__get_Item
		              (&System_Collections_Generic_List_PossibleArtifactsGroupView__TypeInfo);
		    DAT_ram_00a58a15 = '\x01';
		  }
		  param1_00 = unnamed_function_1417
		                        (System_Collections_Generic_List_PossibleArtifactsGroupView__TypeInfo);
		  GAFInternal_Objects_GAFBakedObjectImpl__get_isVisible
		            (param1_00,Method_System_Collections_Generic_List_PossibleArtifactsGroupView___ctor__);
		  *(undefined4 *)(param1 + 0x68) = param1_00;
		  UI_MonoBehaviourWithStates_ClientStateChangedDelegate___Il2CppFullySharedGenericStructType___Invoke
		            (param1,
		             Method_UI_Windows_ClosableBaseWindow_ArtifactComparerWindow_ArtifactComparerWindowArgs___ctor__
		            );
		  return;
		}
		*/

		}

		// Token: 0x06005017 RID: 20503 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005017")]
		[Address(RVA = "0x9E2B", Offset = "0x9E2B", VA = "0x9E2B")]
		public ArtifactComparerWindow()
		{
		}

		// Token: 0x04002B95 RID: 11157
		[Token(Token = "0x4002B95")]
		public const string WINDOW_ID = "Prefabs/UI/Windows/Inventory/ArtifactComparerWindow";

		// Token: 0x04002B96 RID: 11158
		[Token(Token = "0x4002B96")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private ArtifactComparerItemView _leftComparerView;

		// Token: 0x04002B97 RID: 11159
		[Token(Token = "0x4002B97")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private ArtifactComparerItemView _rightComparerView;

		// Token: 0x04002B98 RID: 11160
		[Token(Token = "0x4002B98")]
		[FieldOffset(Offset = "0x44")]
		[SerializeField]
		private ArtifactComparerTable _table;

		// Token: 0x04002B99 RID: 11161
		[Token(Token = "0x4002B99")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private ArtifactComparerPowerBars _powerBars;

		// Token: 0x04002B9A RID: 11162
		[Token(Token = "0x4002B9A")]
		[FieldOffset(Offset = "0x4C")]
		[SerializeField]
		private TextMeshProUGUI _slotTitle;

		// Token: 0x04002B9B RID: 11163
		[Token(Token = "0x4002B9B")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Transform _possibleArtifactsContainer;

		// Token: 0x04002B9C RID: 11164
		[Token(Token = "0x4002B9C")]
		[FieldOffset(Offset = "0x54")]
		[SerializeField]
		private FiltersView _filtersView;

		// Token: 0x04002B9D RID: 11165
		[Token(Token = "0x4002B9D")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private SkillSelectorView _skillSelectorView;

		// Token: 0x04002B9E RID: 11166
		[Token(Token = "0x4002B9E")]
		[FieldOffset(Offset = "0x5C")]
		[SerializeField]
		private ToggleButton _skillSelectorButton;

		// Token: 0x04002B9F RID: 11167
		[Token(Token = "0x4002B9F")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private PossibleArtifactsGroupView _possibleArtifactsGroupViewPrefab;

		// Token: 0x04002BA0 RID: 11168
		[Token(Token = "0x4002BA0")]
		[FieldOffset(Offset = "0x64")]
		private GameObjectPool<PossibleArtifactsGroupView> _possibleArtifactsGroupPool;

		// Token: 0x04002BA1 RID: 11169
		[Token(Token = "0x4002BA1")]
		[FieldOffset(Offset = "0x68")]
		private List<PossibleArtifactsGroupView> _currentPossibleArtifactsroups;

		// Token: 0x04002BA2 RID: 11170
		[Token(Token = "0x4002BA2")]
		[FieldOffset(Offset = "0x6C")]
		private ArtifactComparerEvents _events;

		// Token: 0x04002BA3 RID: 11171
		[Token(Token = "0x4002BA3")]
		[FieldOffset(Offset = "0x70")]
		private ArtifactComparerModel _model;

		// Token: 0x04002BA4 RID: 11172
		[Token(Token = "0x4002BA4")]
		[FieldOffset(Offset = "0x74")]
		private ArtifactComparerController _controller;

		// Token: 0x04002BA5 RID: 11173
		[Token(Token = "0x4002BA5")]
		[FieldOffset(Offset = "0x78")]
		private ArtifactComparerWindowMediator _mediator;

		// Token: 0x04002BA8 RID: 11176
		[Token(Token = "0x4002BA8")]
		[FieldOffset(Offset = "0x84")]
		private Dictionary<ArtikulTypeDic, List<ArtifactData>> _possibleArtifacts;

		// Token: 0x02000CDA RID: 3290
		[Token(Token = "0x2000CDA")]
		public class ArtifactComparerWindowArgs : BaseWindowArgs
		{
			// Token: 0x06005018 RID: 20504 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6005018")]
			[Address(RVA = "0x9E2C", Offset = "0x9E2C", VA = "0x9E2C")]
			public ArtifactComparerWindowArgs()
			{
			}

			// Token: 0x04002BA9 RID: 11177
			[Token(Token = "0x4002BA9")]
			[FieldOffset(Offset = "0x18")]
			public ArtifactData ArtifactData;

			// Token: 0x04002BAA RID: 11178
			[Token(Token = "0x4002BAA")]
			[FieldOffset(Offset = "0x1C")]
			public ArtifactComparerEvents Events;

			// Token: 0x04002BAB RID: 11179
			[Token(Token = "0x4002BAB")]
			[FieldOffset(Offset = "0x20")]
			public ArtifactComparerController Controller;

			// Token: 0x04002BAC RID: 11180
			[Token(Token = "0x4002BAC")]
			[FieldOffset(Offset = "0x24")]
			public ArtifactComparerModel Model;

			// Token: 0x04002BAD RID: 11181
			[Token(Token = "0x4002BAD")]
			[FieldOffset(Offset = "0x28")]
			public bool SameArticulTypeOnly;
		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_Table ---
		void Gameplay_ArtifactComparer_View_ArtifactComparerWindow__get_Table
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a58a0a == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ArtifactData__TypeInfo);
		    DAT_ram_00a58a0a = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x7c);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = UnityEngine_UI_Image__set_sprite(param1_00,param2,0);
		    param2_00 = System_Action_ArtifactData__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_ArtifactData__TypeInfo), iVar2 == 0)) break;
		    iVar2 = func_ii_4329(param1 + 0x7c,iVar2,param1_00);
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


		/* --- GHIDRA: add_SelectArtifactEvent ---
		void Gameplay_ArtifactComparer_View_ArtifactComparerWindow__add_SelectArtifactEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a58a0b == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ArtifactData__TypeInfo);
		    DAT_ram_00a58a0b = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x7c);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = func_ii_7048(param1_00,param2,0);
		    param2_00 = System_Action_ArtifactData__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_ArtifactData__TypeInfo), iVar2 == 0)) break;
		    iVar2 = func_ii_4329(param1 + 0x7c,iVar2,param1_00);
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


		/* --- GHIDRA: remove_SelectArtifactEvent ---
		void Gameplay_ArtifactComparer_View_ArtifactComparerWindow__remove_SelectArtifactEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a58a0c == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&System_Action_ArtifactComparerWindow_ArtifactComparerWindowArgs__TypeInfo);
		    DAT_ram_00a58a0c = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x80);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = UnityEngine_UI_Image__set_sprite(param1_00,param2,0);
		    param2_00 = System_Action_ArtifactComparerWindow_ArtifactComparerWindowArgs__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,
		                             System_Action_ArtifactComparerWindow_ArtifactComparerWindowArgs__TypeInfo
		                            ), iVar2 == 0)) break;
		    iVar2 = func_ii_4329(param1 + 0x80,iVar2,param1_00);
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


		/* --- GHIDRA: add_NewDataEvent ---
		void Gameplay_ArtifactComparer_View_ArtifactComparerWindow__add_NewDataEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a58a0d == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&System_Action_ArtifactComparerWindow_ArtifactComparerWindowArgs__TypeInfo);
		    DAT_ram_00a58a0d = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x80);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = func_ii_7048(param1_00,param2,0);
		    param2_00 = System_Action_ArtifactComparerWindow_ArtifactComparerWindowArgs__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,
		                             System_Action_ArtifactComparerWindow_ArtifactComparerWindowArgs__TypeInfo
		                            ), iVar2 == 0)) break;
		    iVar2 = func_ii_4329(param1 + 0x80,iVar2,param1_00);
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


		/* --- GHIDRA: remove_NewDataEvent ---
		void Gameplay_ArtifactComparer_View_ArtifactComparerWindow__remove_NewDataEvent
		               (int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  undefined4 param1_01;
		  undefined4 param3;
		  undefined4 param2_00;
		  
		  if (DAT_ram_00a58a0e == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_ArtifactComparer_View_ArtifactComparerWindow_OnReleasePooledObject__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_ClosableBaseWindow_ArtifactComparerWindow_ArtifactComparerWindowArgs__Awake__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_Utils_Cache_GameObjectPool_PossibleArtifactsGroupView___ctor__);
		    Mono_Security_ASN1__get_Item(&Utils_Cache_GameObjectPool_PossibleArtifactsGroupView__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Utils_Cache_ObjectPool_ResetPoolObjectDelegate_PossibleArtifactsGroupView__TypeInfo)
		    ;
		    DAT_ram_00a58a0e = '\x01';
		  }
		  UI_Windows_ClosableBaseWindow_object____ctor
		            (param1,
		             Method_UI_Windows_ClosableBaseWindow_ArtifactComparerWindow_ArtifactComparerWindowArgs__Awake__
		            );
		  param3 = *(undefined4 *)(param1 + 0x50);
		  param2_00 = *(undefined4 *)(param1 + 0x60);
		  param1_00 = unnamed_function_1417
		                        (
		                        Utils_Cache_ObjectPool_ResetPoolObjectDelegate_PossibleArtifactsGroupView__TypeInfo
		                        );
		  Core_Cache_AbstractCache_RequestInvoker___Il2CppFullySharedGenericType____Il2CppFullySharedGenericType____ctor
		            (param1_00,param1,
		             Method_Gameplay_ArtifactComparer_View_ArtifactComparerWindow_OnReleasePooledObject__,0)
		  ;
		  param1_01 = unnamed_function_1417(Utils_Cache_GameObjectPool_PossibleArtifactsGroupView__TypeInfo)
		  ;
		  Utils_Cache_GameObjectPoolRestricted_object___CreateInstance
		            (param1_01,param2_00,param3,param1_00,
		             Method_Utils_Cache_GameObjectPool_PossibleArtifactsGroupView___ctor__);
		  *(undefined4 *)(param1 + 100) = param1_01;
		  return;
		}
		*/


		/* --- GHIDRA: get_PossibleArtifacts ---
		void Gameplay_ArtifactComparer_View_ArtifactComparerWindow__get_PossibleArtifacts
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  *(undefined4 *)(param1 + 0x84) = param2;
		  Gameplay_ArtifactComparer_View_ArtifactComparerWindow__set_PossibleArtifacts(param1,param1);
		  return;
		}
		*/


		/* --- GHIDRA: set_PossibleArtifacts ---
		void Gameplay_ArtifactComparer_View_ArtifactComparerWindow__set_PossibleArtifacts
		               (int param1,undefined4 param2)
		
		{
		  bool bVar1;
		  undefined4 param3;
		  int iVar2;
		  undefined4 uVar3;
		  int *piVar4;
		  int param2_00;
		  int iVar5;
		  int param2_01;
		  int iVar6;
		  uint uVar7;
		  int local_30;
		  undefined8 *puStack_2c;
		  undefined8 local_28;
		  undefined8 local_20;
		  undefined8 local_18;
		  undefined8 local_10;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a58a13 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ArtifactData__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_ArtifactComparer_View_ArtifactComparerWindow_ViewOnClickEvent__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_ArtikulTypeDic__List_ArtifactData___get_Item__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_ArtikulTypeDic__List_ArtifactData___get_Keys__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_KeyCollection_Enumerator_ArtikulTypeDic__List_ArtifactData___Dispose__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_List_Enumerator_PossibleArtifactsGroupView__Dispose__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_KeyCollection_Enumerator_ArtikulTypeDic__List_ArtifactData___MoveNext__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_List_Enumerator_PossibleArtifactsGroupView__MoveNext__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_KeyCollection_Enumerator_ArtikulTypeDic__List_ArtifactData___get_Current__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_List_Enumerator_PossibleArtifactsGroupView__get_Current__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_KeyCollection_ArtikulTypeDic__List_ArtifactData___GetEnumerator__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_PossibleArtifactsGroupView__Add__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_PossibleArtifactsGroupView__Clear__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_PossibleArtifactsGroupView__GetEnumerator__);
		    Mono_Security_ASN1__get_Item(&Method_Utils_Cache_ObjectPool_PossibleArtifactsGroupView__Get__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Utils_Cache_ObjectPool_PossibleArtifactsGroupView__Release__);
		    DAT_ram_00a58a13 = '\x01';
		  }
		  local_8 = 0;
		  local_10 = 0;
		  local_18 = 0;
		  local_20 = 0;
		  System_Collections_Generic_List_RegexCharClass_SingleRange___ForEach
		            (&local_30,*(undefined4 *)(param1 + 0x68),
		             Method_System_Collections_Generic_List_PossibleArtifactsGroupView__GetEnumerator__);
		  local_8 = local_28;
		  local_30 = 0;
		  puStack_2c = &local_10;
		  do {
		    DAT_ram_009d3e38 = 0;
		    iVar2 = import::env::invoke_iii
		                      (s_struct_Uniforms___color__array<v_ram_00000aff + 0x44,&local_10,
		                       Method_System_Collections_Generic_List_Enumerator_PossibleArtifactsGroupView__MoveNext__
		                      );
		    iVar6 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar6 == 1) {
		      uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80f5f0ee;
		    }
		    if (iVar2 == 0) goto code_r0x80f5f144;
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_viii
		              (s_struct_Uniforms___color__array<v_ram_00001b87 + 0x18,*(undefined4 *)(param1 + 100),
		               local_8._4_4_,Method_Utils_Cache_ObjectPool_PossibleArtifactsGroupView__Release__);
		    iVar6 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		  } while (iVar6 != 1);
		  uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x80f5f0ee:
		  iVar6 = global_1;
		  iVar2 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		  if (iVar6 == iVar2) {
		    piVar4 = (int *)import::env::__cxa_begin_catch(uVar3);
		    iVar2 = *piVar4;
		    DAT_ram_009d3e38 = 0;
		    local_30 = iVar2;
		    import::env::invoke_v(0x123);
		    iVar6 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar6 != 1) {
		      if (iVar2 != 0) {
		        System_Data_DataSet__ValidateLocaleConstraint(iVar2);
		        do {
		          halt_trap();
		        } while( true );
		      }
		code_r0x80f5f144:
		      DAT_ram_009d3e38 = 0;
		      iVar6 = *(int *)(param1 + 0x68);
		      iVar2 = *(int *)(iVar6 + 0xc);
		      *(undefined4 *)(iVar6 + 0xc) = 0;
		      *(int *)(iVar6 + 0x10) = *(int *)(iVar6 + 0x10) + 1;
		      if (0 < iVar2) {
		        func_ii_2064(*(undefined4 *)(iVar6 + 8),0,iVar2,0);
		      }
		      if (*(int *)(param1 + 0x84) == 0) {
		        return;
		      }
		      uVar3 = System_Collections_Generic_Dictionary_TypeConverterRegistry_ConverterKey__object___System_Collections_Generic_ICollection_System_Collections_Generic_KeyValuePair_TKey_TValue___get_IsReadOnly
		                        (*(int *)(param1 + 0x84),
		                         Method_System_Collections_Generic_Dictionary_ArtikulTypeDic__List_ArtifactData___get_Keys__
		                        );
		      System_Collections_Generic_Dictionary_Int32Enum__object___get_Values
		                (&local_30,uVar3,
		                 Method_System_Collections_Generic_Dictionary_KeyCollection_ArtikulTypeDic__List_ArtifactData___GetEnumerator__
		                );
		      local_18 = local_28;
		      local_20 = CONCAT44(puStack_2c,local_30);
		      local_30 = 0;
		      puStack_2c = &local_20;
		code_r0x80f5f202:
		      do {
		        DAT_ram_009d3e38 = 0;
		        iVar2 = import::env::invoke_iii
		                          (s_struct_Uniforms___color__array<v_ram_00000aff + 0x79,&local_20,
		                           Method_System_Collections_Generic_Dictionary_KeyCollection_Enumerator_ArtikulTypeDic__List_ArtifactData___MoveNext__
		                          );
		        iVar6 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar6 == 1) {
		          uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          goto code_r0x80f5f686;
		        }
		        iVar6 = local_30;
		        if (iVar2 == 0) goto code_r0x80f5f713;
		        DAT_ram_009d3e38 = 0;
		        iVar2 = local_18._4_4_;
		        param2_00 = import::env::invoke_iii
		                              (s_struct_Uniforms___color__array<v_ram_000017c8 + 0x200,
		                               *(undefined4 *)(param1 + 100),
		                               Method_Utils_Cache_ObjectPool_PossibleArtifactsGroupView__Get__);
		        iVar6 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar6 == 1) {
		          uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          goto code_r0x80f5f686;
		        }
		        DAT_ram_009d3e38 = 0;
		        uVar3 = import::env::invoke_iii
		                          (s_struct_Uniforms___color__array<v_ram_00000aff + 0x25c,param2_00,0);
		        if (DAT_ram_009d3e38 == 1) {
		code_r0x80f5f674:
		          DAT_ram_009d3e38 = 0;
		          uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          goto code_r0x80f5f686;
		        }
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_viii(s_struct_Uniforms___color__array<v_ram_000013c7 + 0x26d,uVar3,1,0);
		        if (DAT_ram_009d3e38 == 1) goto code_r0x80f5f674;
		        *(int *)(param2_00 + 0x24) = iVar2;
		        piVar4 = *(int **)(param2_00 + 0x10);
		        if (iVar2 != 0) {
		          DAT_ram_009d3e38 = 0;
		          uVar3 = import::env::invoke_iii
		                            (s_struct_Uniforms___color__array<v_ram_00001b87 + 0x20a,iVar2,0);
		          if (DAT_ram_009d3e38 != 1) goto code_r0x80f5f331;
		code_r0x80f5f66a:
		          DAT_ram_009d3e38 = 0;
		          uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          goto code_r0x80f5f686;
		        }
		        uVar3 = 0;
		code_r0x80f5f331:
		        iVar6 = *piVar4;
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_viii
		                  (*(undefined4 *)(iVar6 + 0x2d0),piVar4,uVar3,*(undefined4 *)(iVar6 + 0x2d4));
		        if (DAT_ram_009d3e38 == 1) goto code_r0x80f5f66a;
		        DAT_ram_009d3e38 = 0;
		        uVar3 = import::env::invoke_ii
		                          (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x199,
		                           System_Action_ArtifactData__TypeInfo);
		        if (DAT_ram_009d3e38 == 1) {
		code_r0x80f5f660:
		          DAT_ram_009d3e38 = 0;
		          uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          goto code_r0x80f5f686;
		        }
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_viiii
		                  (s_struct_Uniforms___color__array<v_ram_000017c8 + 0x241,uVar3,param1,
		                   Method_Gameplay_ArtifactComparer_View_ArtifactComparerWindow_ViewOnClickEvent__,0
		                  );
		        if (DAT_ram_009d3e38 == 1) goto code_r0x80f5f660;
		        if (DAT_ram_00a58a18 == '\0') {
		          DAT_ram_009d3e38 = 0;
		          import::env::invoke_vi(0x7ff,&System_Action_ArtifactData__TypeInfo);
		          if (DAT_ram_009d3e38 == 1) goto code_r0x80f5f660;
		          DAT_ram_00a58a18 = '\x01';
		        }
		        iVar6 = *(int *)(param2_00 + 0x28);
		        do {
		          DAT_ram_009d3e38 = 0;
		          iVar5 = import::env::invoke_iiii
		                            (s_struct_Uniforms___color__array<v_ram_00001b87 + 5,iVar6,uVar3,0);
		          param3 = System_Action_ArtifactData__TypeInfo;
		          if (DAT_ram_009d3e38 == 1) {
		code_r0x80f5f63b:
		            DAT_ram_009d3e38 = 0;
		            uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		            goto code_r0x80f5f686;
		          }
		          if (iVar5 == 0) {
		            param2_01 = 0;
		          }
		          else {
		            DAT_ram_009d3e38 = 0;
		            param2_01 = import::env::invoke_iii
		                                  (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x1a,iVar5,
		                                   System_Action_ArtifactData__TypeInfo);
		            if (DAT_ram_009d3e38 == 1) goto code_r0x80f5f63b;
		            if (param2_01 == 0) {
		              DAT_ram_009d3e38 = 0;
		              import::env::invoke_vii
		                        (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x183,iVar5,param3);
		              iVar6 = DAT_ram_009d3e38;
		              DAT_ram_009d3e38 = 0;
		              if (iVar6 != 1) {
		                do {
		                  halt_trap();
		                } while( true );
		              }
		              uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		              goto code_r0x80f5f686;
		            }
		          }
		          DAT_ram_009d3e38 = 0;
		          iVar5 = func_ii_4329(param2_00 + 0x28,param2_01,iVar6);
		          if (DAT_ram_009d3e38 == 1) goto code_r0x80f5f63b;
		          bVar1 = iVar6 != iVar5;
		          iVar6 = iVar5;
		        } while (bVar1);
		        DAT_ram_009d3e38 = 0;
		        uVar3 = import::env::invoke_iiii
		                          (s_struct_Uniforms___color__array<v_ram_00000f84 + 0x2ec,
		                           *(undefined4 *)(param1 + 0x84),iVar2,
		                           Method_System_Collections_Generic_Dictionary_ArtikulTypeDic__List_ArtifactData___get_Item__
		                          );
		        if (DAT_ram_009d3e38 == 1) {
		code_r0x80f5f5a6:
		          DAT_ram_009d3e38 = 0;
		          uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          goto code_r0x80f5f686;
		        }
		        *(undefined4 *)(param2_00 + 0x2c) = uVar3;
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_vii
		                  (s_struct_Uniforms___color__array<v_ram_00001b87 + 0x20b,param2_00,&local_30);
		        iVar6 = Method_System_Collections_Generic_List_PossibleArtifactsGroupView__Add__;
		        if (DAT_ram_009d3e38 == 1) goto code_r0x80f5f5a6;
		        iVar2 = *(int *)(param1 + 0x68);
		        *(int *)(iVar2 + 0x10) = *(int *)(iVar2 + 0x10) + 1;
		        uVar7 = *(uint *)(iVar2 + 0xc);
		        if (uVar7 < *(uint *)(*(int *)(iVar2 + 8) + 0xc)) {
		          *(uint *)(iVar2 + 0xc) = uVar7 + 1;
		          *(int *)(*(int *)(iVar2 + 8) + uVar7 * 4 + 0x10) = param2_00;
		          goto code_r0x80f5f202;
		        }
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_viii
		                  (s_struct_Uniforms___color__array<v_ram_00000aff + 0x6e,iVar2,param2_00,
		                   *(undefined4 *)(*(int *)(*(int *)(iVar6 + 0x10) + 0x60) + 0x38));
		        iVar6 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		      } while (iVar6 != 1);
		      uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x80f5f686:
		      iVar6 = global_1;
		      iVar2 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		      if (iVar6 == iVar2) {
		        piVar4 = (int *)import::env::__cxa_begin_catch(uVar3);
		        iVar6 = *piVar4;
		        DAT_ram_009d3e38 = 0;
		        local_30 = iVar6;
		        import::env::invoke_v(0x123);
		        iVar2 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar2 != 1) {
		code_r0x80f5f713:
		          DAT_ram_009d3e38 = 0;
		          if (iVar6 == 0) {
		            DAT_ram_009d3e38 = 0;
		            return;
		          }
		          System_Data_DataSet__ValidateLocaleConstraint(iVar6);
		          do {
		            halt_trap();
		          } while( true );
		        }
		        uVar3 = import::env::__cxa_find_matching_catch_2();
		      }
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_00001b87 + 0x20c,&local_30);
		      goto joined_r0x80f5f6fe;
		    }
		    uVar3 = import::env::__cxa_find_matching_catch_2();
		  }
		  DAT_ram_009d3e38 = 0;
		  import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_00001b87 + 0x209,&local_30);
		joined_r0x80f5f6fe:
		  if (DAT_ram_009d3e38 != 1) {
		    DAT_ram_009d3e38 = 0;
		    import::env::__resumeException(uVar3);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  DAT_ram_009d3e38 = 0;
		  import::env::__cxa_find_matching_catch_3(0);
		  unnamed_function_937();
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

}
