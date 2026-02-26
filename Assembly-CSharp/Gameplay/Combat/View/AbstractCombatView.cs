using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Gameplay.Combat.Model;
using Gameplay.Combat.View.Animations;
using Gameplay.Combat.View.GameField;
using Gameplay.Combat.View.Players;
using Gameplay.Combat.View.Spells;
using Gameplay.Combat.View.TurnDisplay;
using Gameplay.Combat.View.VFX;
using Il2CppDummyDll;
using Protocol.Common;
using UnityEngine;

namespace Gameplay.Combat.View
{
	// Token: 0x02000914 RID: 2324
	[Token(Token = "0x2000914")]
	public abstract class AbstractCombatView : MonoBehaviour
	{
		// Token: 0x17000AC7 RID: 2759
		// (get) Token: 0x060036AC RID: 13996 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000AC7")]
		public GameFieldMono GameField
		{
			[Token(Token = "0x60036AC")]
			[Address(RVA = "0x869C", Offset = "0x869C", VA = "0x869C")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000AC8 RID: 2760
		// (get) Token: 0x060036AD RID: 13997 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000AC8")]
		public virtual ITurnStatePointer TurnStatePointer
		{
			[Token(Token = "0x60036AD")]
			[Address(RVA = "0x869D", Offset = "0x869D", VA = "0x869D", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000AC9 RID: 2761
		// (get) Token: 0x060036AE RID: 13998 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000AC9")]
		public Transform ScreenAnimationContainer
		{
			[Token(Token = "0x60036AE")]
			[Address(RVA = "0x869E", Offset = "0x869E", VA = "0x869E")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000ACA RID: 2762
		// (get) Token: 0x060036AF RID: 13999 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000ACA")]
		public CombatEventsToast CombatEventsToast
		{
			[Token(Token = "0x60036AF")]
			[Address(RVA = "0x869F", Offset = "0x869F", VA = "0x869F")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000ACB RID: 2763
		// (get) Token: 0x060036B0 RID: 14000 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000ACB")]
		public CombatGameOverView GameOverView
		{
			[Token(Token = "0x60036B0")]
			[Address(RVA = "0x86A0", Offset = "0x86A0", VA = "0x86A0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000ACC RID: 2764
		// (get) Token: 0x060036B1 RID: 14001 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000ACC")]
		public Dictionary<CombatSpellData, CombatSpellButton> Spells
		{
			[Token(Token = "0x60036B1")]
			[Address(RVA = "0x86A1", Offset = "0x86A1", VA = "0x86A1")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x17000ACD RID: 2765
		// (get) Token: 0x060036B2 RID: 14002 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000ACD")]
		public ICombatSpellDisplay SpellsDisplay
		{
			[Token(Token = "0x60036B2")]
			[Address(RVA = "0x86A2", Offset = "0x86A2", VA = "0x86A2")]
			get
			{
				return null;
			}
		}

		// Token: 0x14000174 RID: 372
		// (add) Token: 0x060036B3 RID: 14003 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x060036B4 RID: 14004 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000174")]
		public event Action<CombatSpellData> OnSpellClick
		{
			[Token(Token = "0x60036B3")]
			[Address(RVA = "0x86A3", Offset = "0x86A3", VA = "0x86A3")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60036B4")]
			[Address(RVA = "0x86A4", Offset = "0x86A4", VA = "0x86A4")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x060036B5 RID: 14005 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60036B5")]
		[Address(RVA = "0x86A5", Offset = "0x86A5", VA = "0x86A5", Slot = "5")]
		protected virtual void OnDestroy()
		{
		}

		// Token: 0x060036B6 RID: 14006 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60036B6")]
		[Address(RVA = "0x86A6", Offset = "0x86A6", VA = "0x86A6", Slot = "6")]
		protected virtual void Start()
		{
		}

		// Token: 0x060036B7 RID: 14007 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60036B7")]
		[Address(RVA = "0x86A7", Offset = "0x86A7", VA = "0x86A7")]
		private void HandleSpellOnclickEvent(CombatSpellData spell)
		{
		/* --- GHIDRA: HandleSpellOnclickEvent ---
		void Gameplay_Combat_View_AbstractCombatView__HandleSpellOnclickEvent(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  int iVar3;
		  undefined4 param2_00;
		  int *piVar4;
		  int local_18;
		  undefined8 *local_14;
		  undefined8 local_10;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a63b15 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Combat_View_Spells_AbstractCombatSpellButton_CombatSpellData__remove_OnClickEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Combat_View_AbstractCombatView_HandleSpellOnclickEvent__);
		    Mono_Security_ASN1__get_Item(&System_Action_CombatSpellData__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_CombatSpellData__CombatSpellButton__get_Values__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_ValueCollection_Enumerator_CombatSpellData__CombatSpellButton__Dispose__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_ValueCollection_Enumerator_CombatSpellData__CombatSpellButton__MoveNext__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_ValueCollection_Enumerator_CombatSpellData__CombatSpellButton__get_Current__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_ValueCollection_CombatSpellData__CombatSpellButton__GetEnumerator__
		              );
		    DAT_ram_00a63b15 = '\x01';
		  }
		  local_8 = 0;
		  local_10 = 0;
		  uVar2 = System_Collections_Generic_Dictionary_int__object___TryAdd
		                    (*(undefined4 *)(param1 + 0x34),
		                     Method_System_Collections_Generic_Dictionary_CombatSpellData__CombatSpellButton__get_Values__
		                    );
		  System_Collections_Generic_Dictionary_Int32Enum__object___get_Values
		            (&local_10,uVar2,
		             Method_System_Collections_Generic_Dictionary_ValueCollection_CombatSpellData__CombatSpellButton__GetEnumerator__
		            );
		  local_18 = 0;
		  local_14 = &local_10;
		  do {
		    DAT_ram_009d3e38 = 0;
		    iVar3 = import::env::invoke_iii
		                      (s_struct_Uniforms___color__array<v_ram_00000f84 + 0x1a2,&local_10,
		                       Method_System_Collections_Generic_Dictionary_ValueCollection_Enumerator_CombatSpellData__CombatSpellButton__MoveNext__
		                      );
		    iVar1 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar1 == 1) {
		      uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x8233f336;
		    }
		    if (iVar3 == 0) {
		      DAT_ram_009d3e38 = 0;
		      return;
		    }
		    DAT_ram_009d3e38 = 0;
		    uVar2 = local_8._4_4_;
		    param2_00 = import::env::invoke_ii
		                          (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x199,
		                           System_Action_CombatSpellData__TypeInfo);
		    if (DAT_ram_009d3e38 == 1) break;
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_viiii
		              (s_struct_Uniforms___color__array<v_ram_000017c8 + 0x241,param2_00,param1,
		               Method_Gameplay_Combat_View_AbstractCombatView_HandleSpellOnclickEvent__,0);
		    if (DAT_ram_009d3e38 == 1) break;
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_viii
		              (s___Scripting__Unity__IO__Archive__ram_00004472 + 0x32,uVar2,param2_00,
		               Method_Gameplay_Combat_View_Spells_AbstractCombatSpellButton_CombatSpellData__remove_OnClickEvent__
		              );
		  } while (DAT_ram_009d3e38 != 1);
		  DAT_ram_009d3e38 = 0;
		  uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x8233f336:
		  iVar1 = global_1;
		  iVar3 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		  if (iVar1 == iVar3) {
		    piVar4 = (int *)import::env::__cxa_begin_catch(uVar2);
		    iVar3 = *piVar4;
		    DAT_ram_009d3e38 = 0;
		    local_18 = iVar3;
		    import::env::invoke_v(0x123);
		    iVar1 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar1 != 1) {
		      if (iVar3 == 0) {
		        DAT_ram_009d3e38 = 0;
		        return;
		      }
		      System_Data_DataSet__ValidateLocaleConstraint(iVar3);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    uVar2 = import::env::__cxa_find_matching_catch_2();
		  }
		  DAT_ram_009d3e38 = 0;
		  import::env::invoke_ii(s___Scripting__Unity__IO__Archive__ram_00004472 + 0x33,&local_18);
		  iVar1 = DAT_ram_009d3e38;
		  DAT_ram_009d3e38 = 0;
		  if (iVar1 != 1) {
		    import::env::__resumeException(uVar2);
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

		// Token: 0x060036B8 RID: 14008 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60036B8")]
		[Address(RVA = "0x86A8", Offset = "0x86A8", VA = "0x86A8")]
		private void RemoveSpellEventHandlers()
		{
		/* --- GHIDRA: RemoveSpellEventHandlers ---
		void Gameplay_Combat_View_AbstractCombatView__RemoveSpellEventHandlers(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  if (DAT_ram_00a63b16 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_CombatSpellData__CombatSpellButton__Clear__
		              );
		    DAT_ram_00a63b16 = '\x01';
		  }
		  Gameplay_Combat_View_AbstractCombatView__HandleSpellOnclickEvent(param1,param1);
		  System_Xml_XmlWellFormedWriter__PushNamespaceImplicit
		            (*(undefined4 *)(param1 + 0x34),
		             Method_System_Collections_Generic_Dictionary_CombatSpellData__CombatSpellButton__Clear__
		            );
		  iVar1 = **(int **)(param1 + 0x1c);
		  (**(code **)((ulonglong)*(uint *)(iVar1 + 0x120) * 4))
		            (*(int **)(param1 + 0x1c),*(undefined4 *)(iVar1 + 0x124));
		  return;
		}
		*/

		}

		// Token: 0x060036B9 RID: 14009 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60036B9")]
		[Address(RVA = "0x86A9", Offset = "0x86A9", VA = "0x86A9", Slot = "7")]
		public virtual void ResetSpells()
		{
		/* --- GHIDRA: ResetSpells ---
		undefined4
		Gameplay_Combat_View_AbstractCombatView__ResetSpells(int param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  
		  uVar1 = Gameplay_Combat_View_AbstractCombatView__AddSpell
		                    (param1,param2,*(undefined4 *)(param1 + 0x1c),param1);
		  return uVar1;
		}
		*/

		}

		// Token: 0x060036BA RID: 14010 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60036BA")]
		[Address(RVA = "0x86AA", Offset = "0x86AA", VA = "0x86AA")]
		public CombatSpellButton AddSpell(CombatSpellData spell)
		{
		/* --- GHIDRA: AddSpell ---
		undefined4
		Gameplay_Combat_View_AbstractCombatView__AddSpell
		          (int param1,undefined4 param2,int param3,undefined4 param4)
		
		{
		  int iVar1;
		  int *piVar2;
		  undefined4 uVar3;
		  int iVar4;
		  
		  if (DAT_ram_00a63b18 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_Combat_View_CombatGameOverView_CombatGameOverViewArgs_TypeInfo);
		    DAT_ram_00a63b18 = '\x01';
		  }
		  piVar2 = *(int **)(param1 + 0x28);
		  uVar3 = *(undefined4 *)(param3 + 8);
		  iVar1 = unnamed_function_1417
		                    (Gameplay_Combat_View_CombatGameOverView_CombatGameOverViewArgs_TypeInfo);
		  *(undefined4 *)(iVar1 + 8) = param2;
		  *(undefined4 *)(iVar1 + 0xc) = uVar3;
		  iVar4 = *piVar2;
		  (**(code **)((ulonglong)*(uint *)(iVar4 + 0xe8) * 4))(piVar2,iVar1,*(undefined4 *)(iVar4 + 0xec));
		  return *(undefined4 *)(param1 + 0x28);
		}
		*/

		/* --- GHIDRA: AddSpell ---
		undefined4
		Gameplay_Combat_View_AbstractCombatView__AddSpell
		          (int param1,undefined4 param2,int param3,undefined4 param4)
		
		{
		  int iVar1;
		  int *piVar2;
		  undefined4 uVar3;
		  int iVar4;
		  
		  if (DAT_ram_00a63b18 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_Combat_View_CombatGameOverView_CombatGameOverViewArgs_TypeInfo);
		    DAT_ram_00a63b18 = '\x01';
		  }
		  piVar2 = *(int **)(param1 + 0x28);
		  uVar3 = *(undefined4 *)(param3 + 8);
		  iVar1 = unnamed_function_1417
		                    (Gameplay_Combat_View_CombatGameOverView_CombatGameOverViewArgs_TypeInfo);
		  *(undefined4 *)(iVar1 + 8) = param2;
		  *(undefined4 *)(iVar1 + 0xc) = uVar3;
		  iVar4 = *piVar2;
		  (**(code **)((ulonglong)*(uint *)(iVar4 + 0xe8) * 4))(piVar2,iVar1,*(undefined4 *)(iVar4 + 0xec));
		  return *(undefined4 *)(param1 + 0x28);
		}
		*/

			return null;
		}

		// Token: 0x060036BB RID: 14011 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60036BB")]
		[Address(RVA = "0x86AB", Offset = "0x86AB", VA = "0x86AB")]
		protected CombatSpellButton AddSpell(CombatSpellData spell, ICombatSpellDisplay accordion)
		{
			return null;
		}

		// Token: 0x060036BC RID: 14012 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60036BC")]
		[Address(RVA = "0x86AC", Offset = "0x86AC", VA = "0x86AC", Slot = "8")]
		protected virtual CombatGameOverView ShowGameOverView(GameOverData gameOver, CombatModel model)
		{
		/* --- GHIDRA: ShowGameOverView ---
		undefined4
		Gameplay_Combat_View_AbstractCombatView__ShowGameOverView
		          (int param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined1 auStack_10 [4];
		  undefined4 local_c;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a63b19 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_CombatSpellData__CombatSpellButton__TryGetValue__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Linq_Enumerable_First_KeyValuePair_CombatSpellData__CombatSpellButton____
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_KeyValuePair_CombatSpellData__CombatSpellButton__get_Value__
		              );
		    DAT_ram_00a63b19 = '\x01';
		  }
		  local_4 = 0;
		  iVar1 = Spine_Unity_AttachmentTools_AttachmentRegionExtensions__GetRegion
		                    (*(undefined4 *)(param1 + 0x34),param2,&local_4,
		                     Method_System_Collections_Generic_Dictionary_CombatSpellData__CombatSpellButton__TryGetValue__
		                    );
		  if (iVar1 == 0) {
		    System_Linq_Enumerable__Where_KeyValuePair_object__object__
		              (auStack_10,*(undefined4 *)(param1 + 0x34),
		               Method_System_Linq_Enumerable_First_KeyValuePair_CombatSpellData__CombatSpellButton____
		              );
		    local_4 = local_c;
		  }
		  return local_4;
		}
		*/

			return null;
		}

		// Token: 0x060036BD RID: 14013 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60036BD")]
		[Address(RVA = "0x86AD", Offset = "0x86AD", VA = "0x86AD")]
		public CombatSpellButton GetSpell(CombatSpellData value)
		{
		/* --- GHIDRA: GetSpell ---
		undefined4
		Gameplay_Combat_View_AbstractCombatView__GetSpell(undefined4 param1,int param2,undefined4 param3)
		
		{
		  undefined4 param3_00;
		  undefined4 uVar1;
		  undefined4 uVar2;
		  undefined8 local_8;
		  
		  if (param2 != 0) {
		    local_8 = Core_Data_UserData__get_UserId(param2,0);
		    uVar1 = func_ii_1081(DAT_ram_00a66968,&local_8);
		    uVar2 = unnamed_function_2232(&StringLiteral_12419);
		    uVar1 = func_ii_4419(uVar2,uVar1,0);
		    uVar2 = unnamed_function_2232(&System_Exception_TypeInfo);
		    uVar2 = unnamed_function_1417(uVar2);
		    System_String__Concat(uVar2,uVar1,0);
		    uVar1 = unnamed_function_2232(&Method_Gameplay_Combat_View_AbstractCombatView_GetPlayer__);
		    func_ii_1050(uVar2,uVar1);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  uVar1 = unnamed_function_2232(&System_ArgumentNullException_TypeInfo);
		  uVar1 = unnamed_function_1417(uVar1);
		  uVar2 = unnamed_function_2232(&StringLiteral_26104);
		  param3_00 = unnamed_function_2232(&StringLiteral_12422);
		  Spine_SkeletonJson__GetInt(uVar1,uVar2,param3_00,0);
		  uVar2 = unnamed_function_2232(&Method_Gameplay_Combat_View_AbstractCombatView_GetPlayer__);
		  func_ii_1050(uVar1,uVar2);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

			return null;
		}

		// Token: 0x060036BE RID: 14014 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60036BE")]
		[Address(RVA = "0x86AE", Offset = "0x86AE", VA = "0x86AE", Slot = "9")]
		public virtual ICombatPLayerView GetPlayer(CombatPlayer player)
		{
		/* --- GHIDRA: GetPlayer ---
		void Gameplay_Combat_View_AbstractCombatView__GetPlayer(int param1,undefined4 param2)
		
		{
		  Gameplay_Combat_View_GameField_GameFieldMono__HandlePressDown(*(undefined4 *)(param1 + 0x14),0);
		  return;
		}
		*/

			return null;
		}

		// Token: 0x060036BF RID: 14015 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60036BF")]
		[Address(RVA = "0x86AF", Offset = "0x86AF", VA = "0x86AF", Slot = "10")]
		public virtual void HideHint()
		{
		/* --- GHIDRA: HideHint ---
		void Gameplay_Combat_View_AbstractCombatView__HideHint
		               (int *param1,undefined4 param2,undefined4 param3,int param4,undefined4 param5)
		
		{
		  undefined4 uVar1;
		  
		  Gameplay_Combat_View_GameField_GameFieldMono__InitField(param1[5],param3,0);
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,param3,param2,*(undefined4 *)(*param1 + 0x104));
		  if (param4 != 0) {
		    (**(code **)((ulonglong)*(uint *)(param4 + 0xc) * 4))
		              (*(undefined4 *)(param4 + 0x20),uVar1,*(undefined4 *)(param4 + 0x14));
		  }
		  return;
		}
		*/

		}

		// Token: 0x060036C0 RID: 14016 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60036C0")]
		[Address(RVA = "0x86B0", Offset = "0x86B0", VA = "0x86B0", Slot = "11")]
		public virtual void ShowGameOver(CombatModel model, GameOverData gameOver, Action<CombatGameOverView> callback)
		{
		/* --- GHIDRA: ShowGameOver ---
		undefined4
		Gameplay_Combat_View_AbstractCombatView__ShowGameOver
		          (int param1,undefined4 param2,undefined4 param3,undefined4 *param4,undefined4 param5)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  
		  if (DAT_ram_00a63b1a == '\0') {
		    Mono_Security_ASN1__get_Item(&UnityEngine_Object_TypeInfo);
		    DAT_ram_00a63b1a = '\x01';
		  }
		  *param4 = 0;
		  uVar2 = *(undefined4 *)(param1 + 0x2c);
		  if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		    func_ii_306000(UnityEngine_Object_TypeInfo);
		  }
		  iVar1 = UnityEngine_TextCore_Text_TextElement__get_textAsset(uVar2,0,0);
		  if (iVar1 == 0) {
		    uVar2 = 0;
		  }
		  else {
		    uVar2 = Gameplay_Combat_View_VFX_StoneDestroyVFX__UpdateElements
		                      (*(undefined4 *)(param1 + 0x2c),param2,param3,param4,0);
		  }
		  return uVar2;
		}
		*/

		}

		// Token: 0x060036C1 RID: 14017 RVA: 0x0000AFB0 File Offset: 0x000091B0
		[Token(Token = "0x60036C1")]
		[Address(RVA = "0x1CE3", Offset = "0x1CE3", VA = "0x1CE3")]
		protected int PointToFieldIndex(Point point)
		{
			return 0;
		}

		// Token: 0x060036C2 RID: 14018 RVA: 0x0000AFC8 File Offset: 0x000091C8
		[Token(Token = "0x60036C2")]
		[Address(RVA = "0x86B1", Offset = "0x86B1", VA = "0x86B1")]
		public bool TryGetVFX(List<StoneMono> stones, bool isMyTurn, out CombatAnimation.IContent content)
		{
		/* --- GHIDRA: TryGetVFX ---
		void Gameplay_Combat_View_AbstractCombatView__TryGetVFX
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  int iVar1;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a63b1b == '\0') {
		    Mono_Security_ASN1__get_Item(&UnityEngine_Object_TypeInfo);
		    DAT_ram_00a63b1b = '\x01';
		  }
		  param1_00 = *(undefined4 *)(param1 + 0x2c);
		  if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		    func_ii_306000(UnityEngine_Object_TypeInfo);
		  }
		  iVar1 = func_ii_3812(param1_00,0,0);
		  if (iVar1 == 0) {
		    Gameplay_Combat_View_VFX_StoneDestroyVFX__TryGetVFX
		              (*(undefined4 *)(param1 + 0x2c),param2,param3,0);
		  }
		  return;
		}
		*/

			return default(bool);
		}

		// Token: 0x060036C3 RID: 14019 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60036C3")]
		[Address(RVA = "0x86B2", Offset = "0x86B2", VA = "0x86B2")]
		public void SetVFXThemeSkin(Sprite skin, Sprite glow)
		{
		/* --- GHIDRA: SetVFXThemeSkin ---
		void Gameplay_Combat_View_AbstractCombatView__SetVFXThemeSkin(int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a63b1c == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_CombatSpellData__CombatSpellButton___ctor__
		              );
		    Mono_Security_ASN1__get_Item
		              (&System_Collections_Generic_Dictionary_CombatSpellData__CombatSpellButton__TypeInfo);
		    DAT_ram_00a63b1c = '\x01';
		  }
		  param1_00 = unnamed_function_1417
		                        (
		                        System_Collections_Generic_Dictionary_CombatSpellData__CombatSpellButton__TypeInfo
		                        );
		  System_Collections_Generic_Dictionary_object__StyleComplexSelector_PseudoStateData___set_Item
		            (param1_00,
		             Method_System_Collections_Generic_Dictionary_CombatSpellData__CombatSpellButton___ctor__
		            );
		  *(undefined4 *)(param1 + 0x34) = param1_00;
		  UnityEngine_RectTransform__GetParentSize(param1,0);
		  return;
		}
		*/

		}

		// Token: 0x060036C4 RID: 14020 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60036C4")]
		[Address(RVA = "0x86B3", Offset = "0x86B3", VA = "0x86B3")]
		protected AbstractCombatView()
		{
		}

		// Token: 0x04001DEB RID: 7659
		[Token(Token = "0x4001DEB")]
		public const int FIELD_SIZE = 6;

		// Token: 0x04001DEC RID: 7660
		[Token(Token = "0x4001DEC")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		protected GameObject Cells;

		// Token: 0x04001DED RID: 7661
		[Token(Token = "0x4001DED")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		protected GameFieldMono gameField;

		// Token: 0x04001DEE RID: 7662
		[Token(Token = "0x4001DEE")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		protected MonoBehaviour _turnStatePointer;

		// Token: 0x04001DEF RID: 7663
		[Token(Token = "0x4001DEF")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		protected AbstractCombatSpellsDisplay _spells;

		// Token: 0x04001DF0 RID: 7664
		[Token(Token = "0x4001DF0")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		protected Transform _screenAnimationContainer;

		// Token: 0x04001DF1 RID: 7665
		[Token(Token = "0x4001DF1")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		protected CombatEventsToast _combatEventsToast;

		// Token: 0x04001DF2 RID: 7666
		[Token(Token = "0x4001DF2")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		protected CombatGameOverView _gameOverView;

		// Token: 0x04001DF3 RID: 7667
		[Token(Token = "0x4001DF3")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private StoneDestroyVFX _stoneDestroyVFX;

		// Token: 0x04001DF4 RID: 7668
		[Token(Token = "0x4001DF4")]
		[FieldOffset(Offset = "0x30")]
		private ITurnStatePointer _turnStatePointerComponent;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_GameField ---
		int Gameplay_Combat_View_AbstractCombatView__get_GameField(int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  int iVar1;
		  
		  if (DAT_ram_00a63b11 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_GameObject_GetComponent_ITurnStatePointer___);
		    DAT_ram_00a63b11 = '\x01';
		  }
		  iVar1 = *(int *)(param1 + 0x30);
		  if (iVar1 == 0) {
		    param1_00 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                          (*(undefined4 *)(param1 + 0x18),0);
		    iVar1 = func_ii_6601(param1_00,Method_UnityEngine_GameObject_GetComponent_ITurnStatePointer___);
		    *(int *)(param1 + 0x30) = iVar1;
		  }
		  return iVar1;
		}
		*/


		/* --- GHIDRA: get_SpellsDisplay ---
		void Gameplay_Combat_View_AbstractCombatView__get_SpellsDisplay
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a63b12 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_CombatSpellData__TypeInfo);
		    DAT_ram_00a63b12 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x38);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = UnityEngine_UI_Image__set_sprite(param1_00,param2,0);
		    param2_00 = System_Action_CombatSpellData__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_CombatSpellData__TypeInfo), iVar2 == 0)) break;
		    iVar2 = func_ii_4329(param1 + 0x38,iVar2,param1_00);
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


		/* --- GHIDRA: add_OnSpellClick ---
		void Gameplay_Combat_View_AbstractCombatView__add_OnSpellClick
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a63b13 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_CombatSpellData__TypeInfo);
		    DAT_ram_00a63b13 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x38);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = func_ii_7048(param1_00,param2,0);
		    param2_00 = System_Action_CombatSpellData__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_CombatSpellData__TypeInfo), iVar2 == 0)) break;
		    iVar2 = func_ii_4329(param1 + 0x38,iVar2,param1_00);
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


		/* --- GHIDRA: remove_OnSpellClick ---
		void Gameplay_Combat_View_AbstractCombatView__remove_OnSpellClick(int param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a63b14 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_CombatSpellData__CombatSpellButton__Clear__
		              );
		    DAT_ram_00a63b14 = '\x01';
		  }
		  Gameplay_Combat_View_AbstractCombatView__HandleSpellOnclickEvent(param1,param1);
		  System_Xml_XmlWellFormedWriter__PushNamespaceImplicit
		            (*(undefined4 *)(param1 + 0x34),
		             Method_System_Collections_Generic_Dictionary_CombatSpellData__CombatSpellButton__Clear__
		            );
		  return;
		}
		*/

}
