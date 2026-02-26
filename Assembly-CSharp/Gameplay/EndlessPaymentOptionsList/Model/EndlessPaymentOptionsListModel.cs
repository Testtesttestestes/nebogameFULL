using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Core.Data;
using Core.Dict;
using Core.Gameplay;
using Core.Gameplay.Managers;
using Core.GameTime;
using Gameplay.Bank.Model;
using Il2CppDummyDll;
using JetBrains.Annotations;
using MVC;
using Protocol.Dic;
using Protocol.Services;

namespace Gameplay.EndlessPaymentOptionsList.Model
{
	// Token: 0x02000847 RID: 2119
	[Token(Token = "0x2000847")]
	public class EndlessPaymentOptionsListModel : AbstractModel
	{
		// Token: 0x170009D4 RID: 2516
		// (get) Token: 0x060031CB RID: 12747 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170009D4")]
		public Dictionaries Dict
		{
			[Token(Token = "0x60031CB")]
			[Address(RVA = "0x8222", Offset = "0x8222", VA = "0x8222")]
			get
			{
				return null;
			}
		}

		// Token: 0x170009D5 RID: 2517
		// (get) Token: 0x060031CC RID: 12748 RVA: 0x0000A200 File Offset: 0x00008400
		// (set) Token: 0x060031CD RID: 12749 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170009D5")]
		public bool RequestedShowList
		{
			[Token(Token = "0x60031CC")]
			[Address(RVA = "0x8223", Offset = "0x8223", VA = "0x8223")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60031CD")]
			[Address(RVA = "0x8224", Offset = "0x8224", VA = "0x8224")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170009D6 RID: 2518
		// (get) Token: 0x060031CE RID: 12750 RVA: 0x0000A218 File Offset: 0x00008418
		// (set) Token: 0x060031CF RID: 12751 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170009D6")]
		public bool IsAwaiteShowDiscountOffer
		{
			[Token(Token = "0x60031CE")]
			[Address(RVA = "0x8225", Offset = "0x8225", VA = "0x8225")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60031CF")]
			[Address(RVA = "0x8226", Offset = "0x8226", VA = "0x8226")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170009D7 RID: 2519
		// (get) Token: 0x060031D0 RID: 12752 RVA: 0x0000A230 File Offset: 0x00008430
		// (set) Token: 0x060031D1 RID: 12753 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170009D7")]
		public int EntryPointShownCount
		{
			[Token(Token = "0x60031D0")]
			[Address(RVA = "0x8227", Offset = "0x8227", VA = "0x8227")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x60031D1")]
			[Address(RVA = "0x8228", Offset = "0x8228", VA = "0x8228")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170009D8 RID: 2520
		// (get) Token: 0x060031D2 RID: 12754 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060031D3 RID: 12755 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170009D8")]
		public PopupScheduleManager.Args EndlessOptionsPopupScheduleArgs
		{
			[Token(Token = "0x60031D2")]
			[Address(RVA = "0x8229", Offset = "0x8229", VA = "0x8229")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60031D3")]
			[Address(RVA = "0x822A", Offset = "0x822A", VA = "0x822A")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170009D9 RID: 2521
		// (get) Token: 0x060031D4 RID: 12756 RVA: 0x0000A248 File Offset: 0x00008448
		// (set) Token: 0x060031D5 RID: 12757 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170009D9")]
		public bool IsDiscountEnabled
		{
			[Token(Token = "0x60031D4")]
			[Address(RVA = "0x822B", Offset = "0x822B", VA = "0x822B")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60031D5")]
			[Address(RVA = "0x822C", Offset = "0x822C", VA = "0x822C")]
			set
			{
			}
		}

		// Token: 0x170009DA RID: 2522
		// (get) Token: 0x060031D6 RID: 12758 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170009DA")]
		[CanBeNull]
		public EndlessPaymentOptionListData LastList
		{
			[Token(Token = "0x60031D6")]
			[Address(RVA = "0x822D", Offset = "0x822D", VA = "0x822D")]
			get
			{
				return null;
			}
		}

		// Token: 0x170009DB RID: 2523
		// (get) Token: 0x060031D7 RID: 12759 RVA: 0x0000A260 File Offset: 0x00008460
		[Token(Token = "0x170009DB")]
		public bool IsAvail
		{
			[Token(Token = "0x60031D7")]
			[Address(RVA = "0x822E", Offset = "0x822E", VA = "0x822E")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170009DC RID: 2524
		// (get) Token: 0x060031D8 RID: 12760 RVA: 0x0000A278 File Offset: 0x00008478
		[Token(Token = "0x170009DC")]
		public bool IsFree
		{
			[Token(Token = "0x60031D8")]
			[Address(RVA = "0x822F", Offset = "0x822F", VA = "0x822F")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170009DD RID: 2525
		// (get) Token: 0x060031D9 RID: 12761 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170009DD")]
		public List<CardData> AllCards
		{
			[Token(Token = "0x60031D9")]
			[Address(RVA = "0x8230", Offset = "0x8230", VA = "0x8230")]
			get
			{
				return null;
			}
		}

		// Token: 0x060031DA RID: 12762 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60031DA")]
		[Address(RVA = "0x8231", Offset = "0x8231", VA = "0x8231")]
		public EndlessPaymentOptionsListModel(int multipleLobbyVisitForEntryPointWidget, int minDisplayOptionCount, IGame game, ICurrentTimeProvider currentTimeProvider, IDictProvider dictProvider, BankManager bank, UserData user)
		{
		/* --- GHIDRA: <TryGetCurrentList>b__48_0 ---
		void Gameplay_EndlessPaymentOptionsList_Model_EndlessPaymentOptionsListModel___TryGetCurrentList_b__48_0
		               (undefined4 param1)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a57654 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_EndlessPaymentOptionsList_Model_EndlessPaymentOptionsListModel___c_TypeInfo
		              );
		    DAT_ram_00a57654 = '\x01';
		  }
		  uVar1 = unnamed_function_1417
		                    (
		                    Gameplay_EndlessPaymentOptionsList_Model_EndlessPaymentOptionsListModel___c_TypeInfo
		                    );
		  **(undefined4 **)
		    (Gameplay_EndlessPaymentOptionsList_Model_EndlessPaymentOptionsListModel___c_TypeInfo + 0x5c) =
		       uVar1;
		  return;
		}
		*/

		/* --- GHIDRA: .ctor ---
		/* WARNING: Removing unreachable block (ram,0x80dbd15a) */
		
		void Gameplay_EndlessPaymentOptionsList_Model_EndlessPaymentOptionsListModel___ctor
		               (int param1,undefined4 param2)
		
		{
		  int iVar1;
		  int iVar2;
		  int iVar3;
		  undefined4 uVar4;
		  int *piVar5;
		  undefined4 uVar6;
		  undefined4 param2_00;
		  int iVar7;
		  uint uVar8;
		  undefined1 auStack_60 [8];
		  undefined8 local_58;
		  undefined8 local_50;
		  int local_48;
		  undefined8 *local_44;
		  undefined8 local_40;
		  undefined8 local_38;
		  undefined4 local_2c;
		  undefined8 local_28;
		  undefined8 local_20;
		  int local_18;
		  undefined8 local_10;
		  undefined8 local_8;
		  
		  uVar6 = 0;
		  if (DAT_ram_00a5764a == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Linq_Enumerable_Single_ProtoGetEndlessPaymentOptionsAns_Types_EndlessPaymentOptionInfo___
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_List_Enumerator_ValueTuple_ProtoGetEndlessPaymentOptionsAns_Types_EndlessPaymentOptionInfo__CardData___Dispose__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_Enumerator_CardData__Dispose__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_Enumerator_CardData__MoveNext__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_List_Enumerator_ValueTuple_ProtoGetEndlessPaymentOptionsAns_Types_EndlessPaymentOptionInfo__CardData___MoveNext__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_List_Enumerator_ValueTuple_ProtoGetEndlessPaymentOptionsAns_Types_EndlessPaymentOptionInfo__CardData___get_Current__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_Enumerator_CardData__get_Current__);
		    Mono_Security_ASN1__get_Item
		              (&
		               System_Func_ProtoGetEndlessPaymentOptionsAns_Types_EndlessPaymentOptionInfo__bool__TypeInfo
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_List_ValueTuple_ProtoGetEndlessPaymentOptionsAns_Types_EndlessPaymentOptionInfo__CardData___Add__
		              );
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_CardData__Add__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_CardData__Clear__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_CardData__GetEnumerator__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_List_ValueTuple_ProtoGetEndlessPaymentOptionsAns_Types_EndlessPaymentOptionInfo__CardData___GetEnumerator__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_List_ValueTuple_ProtoGetEndlessPaymentOptionsAns_Types_EndlessPaymentOptionInfo__CardData____ctor__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               System_Collections_Generic_List_ValueTuple_ProtoGetEndlessPaymentOptionsAns_Types_EndlessPaymentOptionInfo__CardData___TypeInfo
		              );
		    Mono_Security_ASN1__get_Item(&Protocol_Services_ProtoGetEndlessPaymentOptionsAns_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_EndlessPaymentOptionsList_Model_EndlessPaymentOptionsListModel___c__DisplayClass40_0__HandleIsDiscountEnabledChanged_b__0__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Gameplay_EndlessPaymentOptionsList_Model_EndlessPaymentOptionsListModel___c__DisplayClass40_0_TypeInfo
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_ValueTuple_ProtoGetEndlessPaymentOptionsAns_Types_EndlessPaymentOptionInfo__CardData___ctor__
		              );
		    DAT_ram_00a5764a = '\x01';
		  }
		  local_8 = 0;
		  local_10 = 0;
		  local_18 = 0;
		  local_20 = 0;
		  local_28 = 0;
		  local_2c = 0;
		  if (*(char *)(param1 + 0x2c) == '\0') {
		    uVar6 = unnamed_function_1417(Protocol_Services_ProtoGetEndlessPaymentOptionsAns_TypeInfo);
		    Protocol_Services_ProtoGetEndlessPaymentOptionsAns__pb__Google_Protobuf_IMessage_get_Descriptor
		              (uVar6,0);
		    Gameplay_EndlessPaymentOptionsList_Model_EndlessPaymentOptionsListModel__CreateCards
		              (param1,uVar6,auStack_60);
		    return;
		  }
		  iVar2 = unnamed_function_1417
		                    (
		                    System_Collections_Generic_List_ValueTuple_ProtoGetEndlessPaymentOptionsAns_Types_EndlessPaymentOptionInfo__CardData___TypeInfo
		                    );
		  GAFInternal_Objects_GAFBakedObjectImpl__get_isVisible
		            (iVar2,
		             Method_System_Collections_Generic_List_ValueTuple_ProtoGetEndlessPaymentOptionsAns_Types_EndlessPaymentOptionInfo__CardData____ctor__
		            );
		  System_Collections_Generic_List_RegexCharClass_SingleRange___ForEach
		            (&local_40,*(undefined4 *)(param1 + 0x24),
		             Method_System_Collections_Generic_List_CardData__GetEnumerator__);
		  local_8 = local_38;
		  local_10 = local_40;
		  local_48 = 0;
		  local_44 = &local_10;
		code_r0x80dbd0c5:
		  do {
		    DAT_ram_009d3e38 = 0;
		    iVar3 = import::env::invoke_iii
		                      (s_struct_Uniforms___color__array<v_ram_00000aff + 0x44,&local_10,
		                       Method_System_Collections_Generic_List_Enumerator_CardData__MoveNext__);
		    iVar7 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar7 == 1) {
		      uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80dbd340;
		    }
		    if (iVar3 == 0) {
		      iVar3 = 5;
		      iVar7 = local_48;
		      goto code_r0x80dbd38d;
		    }
		    DAT_ram_009d3e38 = 0;
		    iVar7 = import::env::invoke_ii
		                      (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x199,
		                       Gameplay_EndlessPaymentOptionsList_Model_EndlessPaymentOptionsListModel___c__DisplayClass40_0_TypeInfo
		                      );
		    if (DAT_ram_009d3e38 == 1) {
		      DAT_ram_009d3e38 = 0;
		      uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80dbd340;
		    }
		    *(int *)(iVar7 + 8) = local_8._4_4_;
		    uVar6 = *(undefined4 *)(local_8._4_4_ + 0x14);
		    param2_00 = *(undefined4 *)(*(int *)(param1 + 0x30) + 0xc);
		    DAT_ram_009d3e38 = 0;
		    uVar4 = import::env::invoke_ii
		                      (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x199,
		                       System_Func_ProtoGetEndlessPaymentOptionsAns_Types_EndlessPaymentOptionInfo__bool__TypeInfo
		                      );
		    if (DAT_ram_009d3e38 == 1) {
		code_r0x80dbd31a:
		      DAT_ram_009d3e38 = 0;
		      uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80dbd340;
		    }
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_viiii
		              (s_struct_Uniforms___color__array<v_ram_00000aff + 0x21b,uVar4,iVar7,
		               Method_Gameplay_EndlessPaymentOptionsList_Model_EndlessPaymentOptionsListModel___c__DisplayClass40_0__HandleIsDiscountEnabledChanged_b__0__
		               ,0);
		    if (DAT_ram_009d3e38 == 1) goto code_r0x80dbd31a;
		    DAT_ram_009d3e38 = 0;
		    uVar4 = import::env::invoke_iiii
		                      (s_struct_Uniforms___color__array<v_ram_000017c8 + 0x33e,param2_00,uVar4,
		                       Method_System_Linq_Enumerable_Single_ProtoGetEndlessPaymentOptionsAns_Types_EndlessPaymentOptionInfo___
		                      );
		    iVar3 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar3 == 1) {
		      uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80dbd340;
		    }
		    DAT_ram_009d3e38 = 0;
		    local_50 = 0;
		    System_Text_Formatting_StringView__get_IsEmpty
		              (&local_50,uVar4,*(undefined4 *)(iVar7 + 8),
		               Method_System_ValueTuple_ProtoGetEndlessPaymentOptionsAns_Types_EndlessPaymentOptionInfo__CardData___ctor__
		              );
		    iVar7 = 
		    Method_System_Collections_Generic_List_ValueTuple_ProtoGetEndlessPaymentOptionsAns_Types_EndlessPaymentOptionInfo__CardData___Add__
		    ;
		    if (DAT_ram_009d3e38 == 1) break;
		    *(int *)(iVar2 + 0x10) = *(int *)(iVar2 + 0x10) + 1;
		    uVar8 = *(uint *)(iVar2 + 0xc);
		    if (uVar8 < *(uint *)(*(int *)(iVar2 + 8) + 0xc)) {
		      *(uint *)(iVar2 + 0xc) = uVar8 + 1;
		      *(undefined8 *)(*(int *)(iVar2 + 8) + uVar8 * 8 + 0x10) = local_50;
		      goto code_r0x80dbd0c5;
		    }
		    DAT_ram_009d3e38 = 0;
		    local_58 = local_50;
		    local_40 = local_50;
		    import::env::invoke_viii
		              (s_struct_Uniforms___color__vec4<f3_ram_00000856 + 0x22a,iVar2,&local_58,
		               *(undefined4 *)(*(int *)(*(int *)(iVar7 + 0x10) + 0x60) + 0x38));
		  } while (DAT_ram_009d3e38 != 1);
		  DAT_ram_009d3e38 = 0;
		  uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x80dbd340:
		  iVar7 = global_1;
		  iVar3 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		  if (iVar7 == iVar3) {
		    piVar5 = (int *)import::env::__cxa_begin_catch(uVar4);
		    iVar7 = *piVar5;
		    iVar3 = 0;
		    DAT_ram_009d3e38 = 0;
		    local_48 = iVar7;
		    import::env::invoke_v(0x123);
		    iVar1 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar1 != 1) {
		code_r0x80dbd38d:
		      DAT_ram_009d3e38 = 0;
		      if (iVar7 != 0) {
		        System_Data_DataSet__ValidateLocaleConstraint(iVar7);
		        do {
		          halt_trap();
		        } while( true );
		      }
		      if ((iVar3 != 0) &&
		         ((((iVar3 == 1 || (iVar3 == 2)) || (iVar3 == 3)) || ((iVar3 == 4 || (iVar3 != 5)))))) {
		        return;
		      }
		      iVar7 = *(int *)(param1 + 0x24);
		      iVar3 = *(int *)(iVar7 + 0xc);
		      *(undefined4 *)(iVar7 + 0xc) = 0;
		      *(int *)(iVar7 + 0x10) = *(int *)(iVar7 + 0x10) + 1;
		      if (0 < iVar3) {
		        func_ii_2064(*(undefined4 *)(iVar7 + 8),0,iVar3,0);
		      }
		      UnityEngine_UIElements_FocusController__GetFocusTargets
		                (&local_28,iVar2,
		                 Method_System_Collections_Generic_List_ValueTuple_ProtoGetEndlessPaymentOptionsAns_Types_EndlessPaymentOptionInfo__CardData___GetEnumerator__
		                );
		      local_48 = 0;
		      local_44 = &local_28;
		      do {
		        while( true ) {
		          do {
		            DAT_ram_009d3e38 = 0;
		            iVar7 = import::env::invoke_iii
		                              (s_struct_Uniforms___color__array<v_ram_000017c8 + 0x341,&local_28,
		                               Method_System_Collections_Generic_List_Enumerator_ValueTuple_ProtoGetEndlessPaymentOptionsAns_Types_EndlessPaymentOptionInfo__CardData___MoveNext__
		                              );
		            iVar2 = DAT_ram_009d3e38;
		            DAT_ram_009d3e38 = 0;
		            if (iVar2 == 1) {
		              uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		              goto code_r0x80dbd5b2;
		            }
		            iVar2 = local_48;
		            if (iVar7 == 0) goto code_r0x80dbd5fb;
		            DAT_ram_009d3e38 = 0;
		            iVar3 = import::env::invoke_iiiiiii
		                              (s_struct_Uniforms___color__array<v_ram_000017c8 + 0x342,param1,uVar6,
		                               local_20._4_4_,(uint)*(byte *)(local_18 + 0x18),&local_2c,auStack_60)
		            ;
		            iVar7 = DAT_ram_009d3e38;
		            iVar2 = Method_System_Collections_Generic_List_CardData__Add__;
		            DAT_ram_009d3e38 = 0;
		            if (iVar7 == 1) {
		              uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		              goto code_r0x80dbd5b2;
		            }
		          } while (iVar3 == 0);
		          iVar7 = *(int *)(param1 + 0x24);
		          *(int *)(iVar7 + 0x10) = *(int *)(iVar7 + 0x10) + 1;
		          uVar8 = *(uint *)(iVar7 + 0xc);
		          if (*(uint *)(*(int *)(iVar7 + 8) + 0xc) <= uVar8) break;
		          *(uint *)(iVar7 + 0xc) = uVar8 + 1;
		          *(undefined4 *)(*(int *)(iVar7 + 8) + uVar8 * 4 + 0x10) = local_2c;
		        }
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_viii
		                  (s_struct_Uniforms___color__array<v_ram_00000aff + 0x6e,iVar7,local_2c,
		                   *(undefined4 *)(*(int *)(*(int *)(iVar2 + 0x10) + 0x60) + 0x38));
		        iVar2 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		      } while (iVar2 != 1);
		      uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x80dbd5b2:
		      iVar2 = global_1;
		      iVar7 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		      if (iVar2 == iVar7) {
		        piVar5 = (int *)import::env::__cxa_begin_catch(uVar4);
		        iVar2 = *piVar5;
		        DAT_ram_009d3e38 = 0;
		        local_48 = iVar2;
		        import::env::invoke_v(0x123);
		        iVar7 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar7 != 1) {
		code_r0x80dbd5fb:
		          DAT_ram_009d3e38 = 0;
		          if (iVar2 == 0) {
		            Gameplay_EndlessPaymentOptionsList_Model_EndlessPaymentOptionsListModel__SetInfo
		                      (param1,auStack_60);
		            return;
		          }
		          System_Data_DataSet__ValidateLocaleConstraint(iVar2);
		          do {
		            halt_trap();
		          } while( true );
		        }
		        uVar4 = import::env::__cxa_find_matching_catch_2();
		      }
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_000017c8 + 0x343,&local_48);
		      goto joined_r0x80dbd64c;
		    }
		    uVar4 = import::env::__cxa_find_matching_catch_2();
		  }
		  DAT_ram_009d3e38 = 0;
		  import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_000017c8 + 0x340,&local_48);
		joined_r0x80dbd64c:
		  if (DAT_ram_009d3e38 != 1) {
		    DAT_ram_009d3e38 = 0;
		    import::env::__resumeException(uVar4);
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

		// Token: 0x060031DB RID: 12763 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60031DB")]
		[Address(RVA = "0x8232", Offset = "0x8232", VA = "0x8232")]
		private void HandleIsDiscountEnabledChanged()
		{
		/* --- GHIDRA: HandleIsDiscountEnabledChanged ---
		/* WARNING: Removing unreachable block (ram,0x80dbe2b9) */
		
		void Gameplay_EndlessPaymentOptionsList_Model_EndlessPaymentOptionsListModel__HandleIsDiscountEnabledChanged
		               (int param1,int param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 uVar2;
		  int iVar3;
		  int iVar4;
		  undefined4 param2_00;
		  int iVar5;
		  int *piVar6;
		  int local_18;
		  undefined8 *local_14;
		  undefined8 local_10;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a5764c == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Linq_Enumerable_Single_ProtoGetEndlessPaymentOptionsAns_Types_EndlessPaymentOptionInfo___
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Linq_Enumerable_ToArray_ProtoGetEndlessPaymentOptionsAns_Types_EndlessPaymentOptionInfo___
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_Enumerator_CardData__Dispose__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_Enumerator_CardData__MoveNext__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_Enumerator_CardData__get_Current__);
		    Mono_Security_ASN1__get_Item
		              (&
		               System_Func_ProtoGetEndlessPaymentOptionsAns_Types_EndlessPaymentOptionInfo__bool__TypeInfo
		              );
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_CardData__GetEnumerator__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_EndlessPaymentOptionsList_Model_EndlessPaymentOptionsListModel___c__DisplayClass42_0__UpdateCards_b__0__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Gameplay_EndlessPaymentOptionsList_Model_EndlessPaymentOptionsListModel___c__DisplayClass42_0_TypeInfo
		              );
		    DAT_ram_00a5764c = '\x01';
		  }
		  local_8 = 0;
		  local_10 = 0;
		  uVar2 = func_ii_6295(*(undefined4 *)(param2 + 0xc),
		                       Method_System_Linq_Enumerable_ToArray_ProtoGetEndlessPaymentOptionsAns_Types_EndlessPaymentOptionInfo___
		                      );
		  System_Collections_Generic_List_RegexCharClass_SingleRange___ForEach
		            (&local_10,*(undefined4 *)(param1 + 0x24),
		             Method_System_Collections_Generic_List_CardData__GetEnumerator__);
		  local_18 = 0;
		  local_14 = &local_10;
		  do {
		    DAT_ram_009d3e38 = 0;
		    iVar3 = import::env::invoke_iii
		                      (s_struct_Uniforms___color__array<v_ram_00000aff + 0x44,&local_10,
		                       Method_System_Collections_Generic_List_Enumerator_CardData__MoveNext__);
		    iVar4 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar4 == 1) {
		      uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x80dbe3c4:
		      iVar4 = global_1;
		      iVar3 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		      if (iVar4 == iVar3) {
		        piVar6 = (int *)import::env::__cxa_begin_catch(uVar2);
		        iVar3 = *piVar6;
		        DAT_ram_009d3e38 = 0;
		        local_18 = iVar3;
		        import::env::invoke_v(0x123);
		        iVar4 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar4 != 1) {
		          iVar4 = 0;
		          if (iVar3 != 0) {
		            System_Data_DataSet__ValidateLocaleConstraint(iVar3);
		            do {
		              halt_trap();
		            } while( true );
		          }
		code_r0x80dbe41a:
		          DAT_ram_009d3e38 = 0;
		          Gameplay_EndlessPaymentOptionsList_Model_EndlessPaymentOptionsListModel__SetInfo
		                    (param1,iVar4);
		          return;
		        }
		        uVar2 = import::env::__cxa_find_matching_catch_2();
		      }
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_000017c8 + 0x344,&local_18);
		      iVar4 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar4 != 1) {
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
		    if (iVar3 == 0) goto code_r0x80dbe41a;
		    DAT_ram_009d3e38 = 0;
		    iVar4 = import::env::invoke_ii
		                      (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x199,
		                       Gameplay_EndlessPaymentOptionsList_Model_EndlessPaymentOptionsListModel___c__DisplayClass42_0_TypeInfo
		                      );
		    if (DAT_ram_009d3e38 == 1) {
		      DAT_ram_009d3e38 = 0;
		      uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80dbe3c4;
		    }
		    *(undefined4 *)(iVar4 + 8) = local_8._4_4_;
		    DAT_ram_009d3e38 = 0;
		    param2_00 = import::env::invoke_ii
		                          (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x199,
		                           System_Func_ProtoGetEndlessPaymentOptionsAns_Types_EndlessPaymentOptionInfo__bool__TypeInfo
		                          );
		    if (DAT_ram_009d3e38 == 1) {
		code_r0x80dbe3a8:
		      DAT_ram_009d3e38 = 0;
		      uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80dbe3c4;
		    }
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_viiii
		              (s_struct_Uniforms___color__array<v_ram_00000aff + 0x21b,param2_00,iVar4,
		               Method_Gameplay_EndlessPaymentOptionsList_Model_EndlessPaymentOptionsListModel___c__DisplayClass42_0__UpdateCards_b__0__
		               ,0);
		    if (DAT_ram_009d3e38 == 1) goto code_r0x80dbe3a8;
		    DAT_ram_009d3e38 = 0;
		    iVar5 = import::env::invoke_iiii
		                      (s_struct_Uniforms___color__array<v_ram_000017c8 + 0x33e,uVar2,param2_00,
		                       Method_System_Linq_Enumerable_Single_ProtoGetEndlessPaymentOptionsAns_Types_EndlessPaymentOptionInfo___
		                      );
		    iVar3 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar3 == 1) {
		      uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80dbe3c4;
		    }
		    iVar4 = *(int *)(iVar4 + 8);
		    *(int *)(iVar4 + 0x1c) = iVar5;
		    bVar1 = *(char *)(iVar5 + 0x10) != '\0';
		    if (bVar1) {
		      *(undefined1 *)(iVar5 + 0x10) = 1;
		    }
		    *(bool *)(iVar4 + 0x20) = bVar1;
		  } while( true );
		}
		*/

		}

		// Token: 0x060031DC RID: 12764 RVA: 0x0000A290 File Offset: 0x00008490
		[Token(Token = "0x60031DC")]
		[Address(RVA = "0x1B0A", Offset = "0x1B0A", VA = "0x1B0A")]
		private bool TryConstructCard(EndlessPaymentOptionListData list, ProtoGetEndlessPaymentOptionsAns.Types.EndlessPaymentOptionInfo info, bool isLock, out CardData result)
		{
		/* --- GHIDRA: TryConstructCard ---
		int * Gameplay_EndlessPaymentOptionsList_Model_EndlessPaymentOptionsListModel__TryConstructCard
		                (int *param1)
		
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

			return default(bool);
		}

		// Token: 0x060031DD RID: 12765 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60031DD")]
		[Address(RVA = "0x8233", Offset = "0x8233", VA = "0x8233")]
		private void UpdateCards(ProtoGetEndlessPaymentOptionsAns optionInfos)
		{
		/* --- GHIDRA: UpdateCards ---
		/* WARNING: Removing unreachable block (ram,0x80dbe712) */
		
		void Gameplay_EndlessPaymentOptionsList_Model_EndlessPaymentOptionsListModel__UpdateCards
		               (int param1,int param2,undefined4 param3)
		
		{
		  uint uVar1;
		  undefined4 uVar2;
		  int param1_00;
		  int iVar3;
		  undefined4 *puVar4;
		  undefined4 uVar5;
		  uint uVar6;
		  int *piVar7;
		  uint *puVar8;
		  int iVar9;
		  int iVar10;
		  uint uVar11;
		  int *piVar12;
		  int local_14;
		  int **local_10;
		  undefined4 local_c;
		  int *local_8;
		  int local_4;
		  
		  uVar1 = 0;
		  if (DAT_ram_00a5764d == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Linq_Enumerable_SingleOrDefault_ProtoGetEndlessPaymentOptionsAns_Types_EndlessPaymentOptionInfo___
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Linq_Enumerable_ToArray_ProtoGetEndlessPaymentOptionsAns_Types_EndlessPaymentOptionInfo___
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               System_Func_ProtoGetEndlessPaymentOptionsAns_Types_EndlessPaymentOptionInfo__bool__TypeInfo
		              );
		    Mono_Security_ASN1__get_Item(&System_IDisposable_TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_IEnumerator_uint__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_IEnumerator_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_CardData__AddRange__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_CardData__Add__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_CardData__Clear__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_CardData___ctor__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_List_CardData__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_uint__GetEnumerator__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_EndlessPaymentOptionsList_Model_EndlessPaymentOptionsListModel___c__DisplayClass43_0__CreateCards_b__0__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Gameplay_EndlessPaymentOptionsList_Model_EndlessPaymentOptionsListModel___c__DisplayClass43_0_TypeInfo
		              );
		    DAT_ram_00a5764d = '\x01';
		  }
		  local_4 = 0;
		  local_8 = (int *)0x0;
		  local_c = 0;
		  iVar9 = *(int *)(param1 + 0x24);
		  iVar10 = *(int *)(iVar9 + 0xc);
		  *(undefined4 *)(iVar9 + 0xc) = 0;
		  *(int *)(iVar9 + 0x10) = *(int *)(iVar9 + 0x10) + 1;
		  if (0 < iVar10) {
		    func_ii_2064(*(undefined4 *)(iVar9 + 8),0,iVar10,0);
		  }
		  uVar2 = func_ii_6295(*(undefined4 *)(param2 + 0xc),
		                       Method_System_Linq_Enumerable_ToArray_ProtoGetEndlessPaymentOptionsAns_Types_EndlessPaymentOptionInfo___
		                      );
		  param1_00 = unnamed_function_1417(System_Collections_Generic_List_CardData__TypeInfo);
		  GAFInternal_Objects_GAFBakedObjectImpl__get_isVisible
		            (param1_00,Method_System_Collections_Generic_List_CardData___ctor__);
		  iVar3 = Gameplay_EndlessPaymentOptionsList_Model_EndlessPaymentOptionsListModel__GetCardForDisplay
		                    (param1,&local_4,iVar9);
		  iVar10 = local_4;
		  if (iVar3 == 0) {
		code_r0x80dbea95:
		    func_ii_6335(*(undefined4 *)(param1 + 0x24),param1_00,
		                 Method_System_Collections_Generic_List_CardData__AddRange__);
		    Gameplay_EndlessPaymentOptionsList_Model_EndlessPaymentOptionsListModel__SetInfo(param1,iVar9);
		    return;
		  }
		  local_8 = (int *)Google_Protobuf_Collections_RepeatedField_float___Equals
		                             (*(undefined4 *)(*(int *)(local_4 + 8) + 0x20),
		                              Method_Google_Protobuf_Collections_RepeatedField_uint__GetEnumerator__
		                             );
		  local_14 = 0;
		  local_10 = &local_8;
		code_r0x80dbe5d2:
		  piVar7 = local_8;
		  iVar9 = *local_8;
		  if (*(ushort *)(iVar9 + 0xb6) != 0) {
		    uVar6 = 0;
		    do {
		      piVar12 = (int *)(*(int *)(iVar9 + 0x58) + uVar6 * 8);
		      if (System_Collections_IEnumerator_TypeInfo == *piVar12) {
		        puVar4 = (undefined4 *)(iVar9 + piVar12[1] * 8 + 0xc0);
		        goto code_r0x80dbe66b;
		      }
		      uVar6 = uVar6 + 1;
		    } while (*(ushort *)(iVar9 + 0xb6) != uVar6);
		  }
		  DAT_ram_009d3e38 = 0;
		  puVar4 = (undefined4 *)
		           import::env::invoke_iiii
		                     (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_8,
		                      System_Collections_IEnumerator_TypeInfo,0);
		  if (DAT_ram_009d3e38 == 1) {
		code_r0x80dbe9a7:
		    DAT_ram_009d3e38 = 0;
		    uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		    goto code_r0x80dbe9b9;
		  }
		code_r0x80dbe66b:
		  DAT_ram_009d3e38 = 0;
		  iVar9 = import::env::invoke_iii(*puVar4,piVar7,puVar4[1]);
		  if (DAT_ram_009d3e38 == 1) goto code_r0x80dbe9a7;
		  if (iVar9 == 0) goto code_r0x80dbea02;
		  DAT_ram_009d3e38 = 0;
		  iVar9 = import::env::invoke_ii
		                    (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x199,
		                     Gameplay_EndlessPaymentOptionsList_Model_EndlessPaymentOptionsListModel___c__DisplayClass43_0_TypeInfo
		                    );
		  piVar7 = local_8;
		  if (DAT_ram_009d3e38 == 1) {
		    DAT_ram_009d3e38 = 0;
		    uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		    goto code_r0x80dbe9b9;
		  }
		  iVar3 = *local_8;
		  if (*(ushort *)(iVar3 + 0xb6) != 0) {
		    uVar6 = 0;
		    do {
		      piVar12 = (int *)(*(int *)(iVar3 + 0x58) + uVar6 * 8);
		      if (System_Collections_Generic_IEnumerator_uint__TypeInfo == *piVar12) {
		        puVar4 = (undefined4 *)(iVar3 + piVar12[1] * 8 + 0xc0);
		        goto code_r0x80dbe7ad;
		      }
		      uVar6 = uVar6 + 1;
		    } while (*(ushort *)(iVar3 + 0xb6) != uVar6);
		  }
		  DAT_ram_009d3e38 = 0;
		  puVar4 = (undefined4 *)
		           import::env::invoke_iiii
		                     (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_8,
		                      System_Collections_Generic_IEnumerator_uint__TypeInfo,0);
		  if (DAT_ram_009d3e38 == 1) {
		code_r0x80dbe933:
		    DAT_ram_009d3e38 = 0;
		    uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		    goto code_r0x80dbe9b9;
		  }
		code_r0x80dbe7ad:
		  DAT_ram_009d3e38 = 0;
		  uVar5 = import::env::invoke_iii(*puVar4,piVar7,puVar4[1]);
		  if (DAT_ram_009d3e38 == 1) goto code_r0x80dbe933;
		  *(undefined4 *)(iVar9 + 8) = uVar5;
		  DAT_ram_009d3e38 = 0;
		  uVar5 = import::env::invoke_ii
		                    (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x199,
		                     System_Func_ProtoGetEndlessPaymentOptionsAns_Types_EndlessPaymentOptionInfo__bool__TypeInfo
		                    );
		  if (DAT_ram_009d3e38 == 1) {
		code_r0x80dbe93d:
		    DAT_ram_009d3e38 = 0;
		    uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		    goto code_r0x80dbe9b9;
		  }
		  DAT_ram_009d3e38 = 0;
		  import::env::invoke_viiii
		            (s_struct_Uniforms___color__array<v_ram_00000aff + 0x21b,uVar5,iVar9,
		             Method_Gameplay_EndlessPaymentOptionsList_Model_EndlessPaymentOptionsListModel___c__DisplayClass43_0__CreateCards_b__0__
		             ,0);
		  if (DAT_ram_009d3e38 == 1) goto code_r0x80dbe93d;
		  DAT_ram_009d3e38 = 0;
		  iVar3 = import::env::invoke_iiii
		                    (s_struct_Uniforms___color__array<v_ram_000017c8 + 0x339,uVar2,uVar5,
		                     Method_System_Linq_Enumerable_SingleOrDefault_ProtoGetEndlessPaymentOptionsAns_Types_EndlessPaymentOptionInfo___
		                    );
		  iVar9 = DAT_ram_009d3e38;
		  DAT_ram_009d3e38 = 0;
		  if (iVar9 != 1) {
		    if (iVar3 != 0) {
		      DAT_ram_009d3e38 = 0;
		      uVar6 = import::env::invoke_iiiiiii
		                        (s_struct_Uniforms___color__array<v_ram_000017c8 + 0x342,param1,iVar10,iVar3
		                         ,uVar1 & 1,&local_c,iVar9);
		      iVar3 = DAT_ram_009d3e38;
		      iVar9 = Method_System_Collections_Generic_List_CardData__Add__;
		      DAT_ram_009d3e38 = 0;
		      if (iVar3 == 1) {
		        uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x80dbe9b9;
		      }
		      if (uVar6 != 0) {
		        *(int *)(param1_00 + 0x10) = *(int *)(param1_00 + 0x10) + 1;
		        uVar11 = *(uint *)(param1_00 + 0xc);
		        if (uVar11 < *(uint *)(*(int *)(param1_00 + 8) + 0xc)) {
		          *(uint *)(param1_00 + 0xc) = uVar11 + 1;
		          *(undefined4 *)(*(int *)(param1_00 + 8) + uVar11 * 4 + 0x10) = local_c;
		        }
		        else {
		          DAT_ram_009d3e38 = 0;
		          import::env::invoke_viii
		                    (s_struct_Uniforms___color__array<v_ram_00000aff + 0x6e,param1_00,local_c,
		                     *(undefined4 *)(*(int *)(*(int *)(iVar9 + 0x10) + 0x60) + 0x38));
		          iVar9 = DAT_ram_009d3e38;
		          DAT_ram_009d3e38 = 0;
		          if (iVar9 == 1) {
		            uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		            goto code_r0x80dbe9b9;
		          }
		        }
		      }
		      uVar1 = uVar1 | uVar6 ^ 1;
		    }
		    goto code_r0x80dbe5d2;
		  }
		  uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x80dbe9b9:
		  iVar9 = global_1;
		  iVar10 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		  if (iVar9 == iVar10) {
		    piVar7 = (int *)import::env::__cxa_begin_catch(uVar2);
		    local_14 = *piVar7;
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_v(0x123);
		    iVar9 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar9 != 1) {
		code_r0x80dbea02:
		      DAT_ram_009d3e38 = 0;
		      piVar7 = *local_10;
		      if (piVar7 != (int *)0x0) {
		        uVar1 = 0;
		        iVar9 = *piVar7;
		        if (*(ushort *)(iVar9 + 0xb6) != 0) {
		          do {
		            if (System_IDisposable_TypeInfo == *(int *)(*(int *)(iVar9 + 0x58) + uVar1 * 8)) {
		              puVar8 = (uint *)(iVar9 + *(int *)(*(int *)(iVar9 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0)
		              ;
		              goto code_r0x80dbea7d;
		            }
		            uVar1 = uVar1 + 1;
		          } while (*(ushort *)(iVar9 + 0xb6) != uVar1);
		        }
		        puVar8 = (uint *)func_ii_1080(piVar7,System_IDisposable_TypeInfo,0);
		code_r0x80dbea7d:
		        (**(code **)((ulonglong)*puVar8 * 4))(piVar7,puVar8[1]);
		      }
		      iVar9 = 0;
		      if (local_14 != 0) {
		        System_Data_DataSet__ValidateLocaleConstraint(local_14);
		        do {
		          halt_trap();
		        } while( true );
		      }
		      goto code_r0x80dbea95;
		    }
		    uVar2 = import::env::__cxa_find_matching_catch_2();
		  }
		  DAT_ram_009d3e38 = 0;
		  import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_000017c8 + 0x345,&local_14);
		  iVar9 = DAT_ram_009d3e38;
		  DAT_ram_009d3e38 = 0;
		  if (iVar9 != 1) {
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

		// Token: 0x060031DE RID: 12766 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60031DE")]
		[Address(RVA = "0x8234", Offset = "0x8234", VA = "0x8234")]
		private void CreateCards(ProtoGetEndlessPaymentOptionsAns optionInfos)
		{
		/* --- GHIDRA: CreateCards ---
		void Gameplay_EndlessPaymentOptionsList_Model_EndlessPaymentOptionsListModel__CreateCards
		               (int param1,int param2,undefined4 param3)
		
		{
		  ulonglong local_8;
		  
		  if (DAT_ram_00a5764e == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Nullable_uint__GetValueOrDefault__);
		    Mono_Security_ASN1__get_Item(&Method_System_Nullable_uint___ctor__);
		    Mono_Security_ASN1__get_Item(&Method_System_Nullable_uint__get_HasValue__);
		    DAT_ram_00a5764e = '\x01';
		  }
		  *(int *)(param1 + 0x30) = param2;
		  if (*(int *)(param1 + 0x28) != 0) {
		    local_8 = 0;
		    System_Data_SqlTypes_SqlInt32___ctor
		              (&local_8,*(undefined4 *)(*(int *)(*(int *)(param1 + 0x28) + 8) + 0xc),
		               Method_System_Nullable_uint___ctor__);
		    param2 = *(int *)(param1 + 0x30);
		    if (((local_8 & 0xff) != 0) && (*(int *)(param2 + 0x10) == (int)(local_8 >> 0x20))) {
		      Gameplay_EndlessPaymentOptionsList_Model_EndlessPaymentOptionsListModel__HandleIsDiscountEnabledChanged
		                (param1,param2,param1);
		      return;
		    }
		  }
		  Gameplay_EndlessPaymentOptionsList_Model_EndlessPaymentOptionsListModel__UpdateCards
		            (param1,param2,param1);
		  return;
		}
		*/

		}

		// Token: 0x060031DF RID: 12767 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60031DF")]
		[Address(RVA = "0x8235", Offset = "0x8235", VA = "0x8235")]
		public void SetInfo(ProtoGetEndlessPaymentOptionsAns optionInfos)
		{
		/* --- GHIDRA: SetInfo ---
		void Gameplay_EndlessPaymentOptionsList_Model_EndlessPaymentOptionsListModel__SetInfo
		               (int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  int param2_00;
		  int iVar3;
		  int iVar4;
		  int iVar5;
		  int param2_01;
		  int iVar6;
		  
		  if (DAT_ram_00a5764f == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_CardData__get_Count__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_CardData__get_Item__);
		    DAT_ram_00a5764f = '\x01';
		  }
		  iVar5 = *(int *)(param1 + 0x24);
		  iVar2 = 0;
		  param2_00 = 0;
		  if (0 < *(int *)(iVar5 + 0xc)) {
		    do {
		      uVar1 = 0;
		      iVar4 = System_Linq_Enumerable__ToList_object_
		                        (iVar5,param2_00,Method_System_Collections_Generic_List_CardData__get_Item__
		                        );
		      iVar5 = *(int *)(iVar4 + 0xc);
		      iVar3 = iVar5;
		      if (((*(char *)(iVar4 + 0x20) == '\0') && (iVar2 != 0)) && (*(char *)(iVar2 + 0x20) == '\0'))
		      {
		        uVar1 = System_Linq_Enumerable__ToList_object_
		                          (*(undefined4 *)(param1 + 0x24),param2_00 + -1,
		                           Method_System_Collections_Generic_List_CardData__get_Item__);
		        iVar3 = *(int *)(iVar4 + 0xc);
		      }
		      *(undefined4 *)(iVar5 + 8) = uVar1;
		      param2_01 = param2_00 + 1;
		      uVar1 = 0;
		      iVar5 = *(int *)(param1 + 0x24);
		      iVar6 = *(int *)(iVar5 + 0xc);
		      if (param2_00 < iVar6 + -1) {
		        uVar1 = System_Linq_Enumerable__ToList_object_
		                          (iVar5,param2_01,
		                           Method_System_Collections_Generic_List_CardData__get_Item__);
		        iVar5 = *(int *)(param1 + 0x24);
		        iVar6 = *(int *)(iVar5 + 0xc);
		      }
		      *(undefined4 *)(iVar3 + 0xc) = uVar1;
		      iVar2 = iVar4;
		      param2_00 = param2_01;
		    } while (param2_01 < iVar6);
		  }
		  return;
		}
		*/

		}

		// Token: 0x060031E0 RID: 12768 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60031E0")]
		[Address(RVA = "0x8236", Offset = "0x8236", VA = "0x8236")]
		public void ReLink()
		{
		/* --- GHIDRA: ReLink ---
		undefined4
		Gameplay_EndlessPaymentOptionsList_Model_EndlessPaymentOptionsListModel__ReLink
		          (int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  undefined4 *puVar2;
		  int param1_00;
		  undefined4 param2_00;
		  
		  if (DAT_ram_00a57650 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_ToList_CardData___);
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_Where_CardData___);
		    Mono_Security_ASN1__get_Item(&System_Func_CardData__bool__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_EndlessPaymentOptionsList_Model_EndlessPaymentOptionsListModel___c__GetCards_b__46_0__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_EndlessPaymentOptionsList_Model_EndlessPaymentOptionsListModel___c_TypeInfo
		              );
		    DAT_ram_00a57650 = '\x01';
		  }
		  uVar1 = *(undefined4 *)(param1 + 0x24);
		  if (*(int *)(Gameplay_EndlessPaymentOptionsList_Model_EndlessPaymentOptionsListModel___c_TypeInfo
		              + 0x74) == 0) {
		    func_ii_306000(
		                  Gameplay_EndlessPaymentOptionsList_Model_EndlessPaymentOptionsListModel___c_TypeInfo
		                  );
		  }
		  puVar2 = *(undefined4 **)
		            (Gameplay_EndlessPaymentOptionsList_Model_EndlessPaymentOptionsListModel___c_TypeInfo +
		            0x5c);
		  param1_00 = puVar2[1];
		  if (param1_00 == 0) {
		    if (*(int *)(
		                Gameplay_EndlessPaymentOptionsList_Model_EndlessPaymentOptionsListModel___c_TypeInfo
		                + 0x74) == 0) {
		      func_ii_306000(
		                    Gameplay_EndlessPaymentOptionsList_Model_EndlessPaymentOptionsListModel___c_TypeInfo
		                    );
		      puVar2 = *(undefined4 **)
		                (
		                Gameplay_EndlessPaymentOptionsList_Model_EndlessPaymentOptionsListModel___c_TypeInfo
		                + 0x5c);
		    }
		    param2_00 = *puVar2;
		    param1_00 = unnamed_function_1417(System_Func_CardData__bool__TypeInfo);
		    System_Collections_Generic_Dictionary_uint__object___GetEnumerator
		              (param1_00,param2_00,
		               Method_Gameplay_EndlessPaymentOptionsList_Model_EndlessPaymentOptionsListModel___c__GetCards_b__46_0__
		               ,0);
		    *(int *)(*(int *)(
		                     Gameplay_EndlessPaymentOptionsList_Model_EndlessPaymentOptionsListModel___c_TypeInfo
		                     + 0x5c) + 4) = param1_00;
		  }
		  uVar1 = System_Linq_Enumerable__Where_PlayerLoopSystem_
		                    (uVar1,param1_00,Method_System_Linq_Enumerable_Where_CardData___);
		  uVar1 = System_Linq_Enumerable__Select_object__object_
		                    (uVar1,Method_System_Linq_Enumerable_ToList_CardData___);
		  return uVar1;
		}
		*/

		}

		// Token: 0x060031E1 RID: 12769 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60031E1")]
		[Address(RVA = "0x8237", Offset = "0x8237", VA = "0x8237")]
		public List<CardData> GetCards()
		{
		/* --- GHIDRA: GetCards ---
		int Gameplay_EndlessPaymentOptionsList_Model_EndlessPaymentOptionsListModel__GetCards
		              (int param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  int param2_00;
		  int param3;
		  
		  if (DAT_ram_00a57651 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_CardData__GetRange__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_CardData__get_Count__);
		    DAT_ram_00a57651 = '\x01';
		  }
		  iVar1 = Gameplay_EndlessPaymentOptionsList_Model_EndlessPaymentOptionsListModel__ReLink
		                    (param1,param1);
		  param3 = *(int *)(param1 + 0x20);
		  if (*(int *)(iVar1 + 0xc) < param3) {
		    iVar1 = *(int *)(param1 + 0x24);
		    param2_00 = *(int *)(iVar1 + 0xc) - param3;
		    if (-1 < param2_00) {
		      uVar2 = System_Collections_Generic_List_RenderChain_VisualChangesProcessor_EntryProcessingInfo___GetEnumerator
		                        (iVar1,param2_00,param3,
		                         Method_System_Collections_Generic_List_CardData__GetRange__);
		      return uVar2;
		    }
		  }
		  else {
		    iVar1 = System_Collections_Generic_List_RenderChain_VisualChangesProcessor_EntryProcessingInfo___GetEnumerator
		                      (iVar1,0,param3,Method_System_Collections_Generic_List_CardData__GetRange__);
		  }
		  return iVar1;
		}
		*/

			return null;
		}

		// Token: 0x060031E2 RID: 12770 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60031E2")]
		[Address(RVA = "0x8238", Offset = "0x8238", VA = "0x8238")]
		public List<CardData> GetCardForDisplay()
		{
		/* --- GHIDRA: GetCardForDisplay ---
		undefined4
		Gameplay_EndlessPaymentOptionsList_Model_EndlessPaymentOptionsListModel__GetCardForDisplay
		          (int param1,int *param2,undefined4 param3)
		
		{
		  undefined4 in_register_20000004;
		  undefined8 uVar1;
		  uint *puVar2;
		  undefined4 param1_00;
		  float fVar3;
		  undefined4 uVar4;
		  ulonglong uVar5;
		  longlong lVar6;
		  double dVar7;
		  int *piVar8;
		  int iVar9;
		  undefined4 param1_01;
		  int iVar10;
		  ulonglong uVar11;
		  longlong lVar12;
		  uint uVar13;
		  float8 local_8;
		  
		  if (DAT_ram_00a57652 == '\0') {
		    Mono_Security_ASN1__get_Item(&Utils_BackTime_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_EndlessPaymentOptionsList_Model_EndlessPaymentOptionListData_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_EndlessPaymentOptionsList_Model_EndlessPaymentOptionsListModel__TryGetCurrentList_b__48_0__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Linq_Enumerable_SingleOrDefault_EndlessPaymentOptionListDic___);
		    Mono_Security_ASN1__get_Item(&System_Func_EndlessPaymentOptionListDic__bool__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_GameTime_ICurrentTimeProvider_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Dict_IDictProvider_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_System_Nullable_uint__GetValueOrDefault__);
		    Mono_Security_ASN1__get_Item(&Method_System_Nullable_uint___ctor__);
		    Mono_Security_ASN1__get_Item(&Method_System_Nullable_uint__get_HasValue__);
		    Mono_Security_ASN1__get_Item(&Utils_TimeUtils_TypeInfo);
		    DAT_ram_00a57652 = '\x01';
		  }
		  *param2 = 0;
		  if (*(int *)(param1 + 0x30) == 0) {
		    return 0;
		  }
		  if (*(int *)(param1 + 0x28) != 0) {
		    local_8 = 0.0;
		    System_Data_SqlTypes_SqlInt32___ctor
		              (&local_8,*(undefined4 *)(*(int *)(*(int *)(param1 + 0x28) + 8) + 0xc),
		               Method_System_Nullable_uint___ctor__);
		    if ((((ulonglong)local_8 & 0xff) != 0) &&
		       (*(int *)(*(int *)(param1 + 0x30) + 0x10) == (int)((ulonglong)local_8 >> 0x20))) {
		      *param2 = *(int *)(param1 + 0x28);
		      return 1;
		    }
		  }
		  uVar13 = 0;
		  piVar8 = *(int **)(param1 + 0xc);
		  iVar9 = *piVar8;
		  if (*(ushort *)(iVar9 + 0xb6) != 0) {
		    do {
		      if (Core_Dict_IDictProvider_TypeInfo == *(int *)(*(int *)(iVar9 + 0x58) + uVar13 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar9 + 0x58) + uVar13 * 8 + 4) * 8 + iVar9 + 0xd0);
		        goto code_r0x80dbdcb9;
		      }
		      uVar13 = uVar13 + 1;
		    } while (*(ushort *)(iVar9 + 0xb6) != uVar13);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar8,Core_Dict_IDictProvider_TypeInfo,2);
		code_r0x80dbdcb9:
		  uVar1 = CONCAT44(in_register_20000004,piVar8);
		  iVar9 = (**(code **)((ulonglong)*puVar2 * 4))(uVar1,puVar2[1]);
		  param1_01 = *(undefined4 *)(iVar9 + 0x2f0);
		  uVar13 = 0;
		  uVar4 = (undefined4)((ulonglong)uVar1 >> 0x20);
		  param1_00 = unnamed_function_1417(System_Func_EndlessPaymentOptionListDic__bool__TypeInfo);
		  System_Collections_Generic_Dictionary_uint__object___GetEnumerator
		            (param1_00,param1,
		             Method_Gameplay_EndlessPaymentOptionsList_Model_EndlessPaymentOptionsListModel__TryGetCurrentList_b__48_0__
		             ,0);
		  iVar9 = UI_SimpleIconValue__set_Value
		                    (param1_01,param1_00,
		                     Method_System_Linq_Enumerable_SingleOrDefault_EndlessPaymentOptionListDic___);
		  if (iVar9 == 0) {
		    return 0;
		  }
		  uVar11 = *(ulonglong *)(iVar9 + 0x18);
		  piVar8 = *(int **)(param1 + 0x1c);
		  iVar10 = *piVar8;
		  if (*(ushort *)(iVar10 + 0xb6) != 0) {
		    do {
		      if (Core_GameTime_ICurrentTimeProvider_TypeInfo ==
		          *(int *)(*(int *)(iVar10 + 0x58) + uVar13 * 8)) {
		        puVar2 = (uint *)(iVar10 + *(int *)(*(int *)(iVar10 + 0x58) + uVar13 * 8 + 4) * 8 + 0xc0);
		        goto code_r0x80dbdd7a;
		      }
		      uVar13 = uVar13 + 1;
		    } while (*(ushort *)(iVar10 + 0xb6) != uVar13);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar8,Core_GameTime_ICurrentTimeProvider_TypeInfo,0);
		code_r0x80dbdd7a:
		  uVar13 = 0;
		  uVar1 = CONCAT44(uVar4,piVar8);
		  uVar5 = (**(code **)((ulonglong)*puVar2 * 4))(uVar1,puVar2[1]);
		  uVar4 = (undefined4)((ulonglong)uVar1 >> 0x20);
		  if (uVar11 <= uVar5) {
		    return 0;
		  }
		  lVar12 = *(longlong *)(iVar9 + 0x18);
		  piVar8 = *(int **)(param1 + 0x1c);
		  iVar10 = *piVar8;
		  if (*(ushort *)(iVar10 + 0xb6) != 0) {
		    do {
		      if (Core_GameTime_ICurrentTimeProvider_TypeInfo ==
		          *(int *)(*(int *)(iVar10 + 0x58) + uVar13 * 8)) {
		        puVar2 = (uint *)(iVar10 + *(int *)(*(int *)(iVar10 + 0x58) + uVar13 * 8 + 4) * 8 + 0xc0);
		        goto code_r0x80dbde09;
		      }
		      uVar13 = uVar13 + 1;
		    } while (*(ushort *)(iVar10 + 0xb6) != uVar13);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar8,Core_GameTime_ICurrentTimeProvider_TypeInfo,0);
		code_r0x80dbde09:
		  lVar6 = (**(code **)((ulonglong)*puVar2 * 4))(CONCAT44(uVar4,piVar8),puVar2[1]);
		  if (*(int *)(Utils_TimeUtils_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Utils_TimeUtils_TypeInfo);
		  }
		  fVar3 = Utils_StringUtils___cctor(lVar12 - lVar6,0);
		  dVar7 = unnamed_function_4206((double)fVar3,&local_8);
		  if (0.0 <= fVar3) {
		    if (dVar7 == 0.5) {
		      if (ABS((double)local_8) < 9.223372036854776e+18) {
		        uVar11 = (ulonglong)(double)local_8;
		      }
		      else {
		        uVar11 = 0;
		      }
		      fVar3 = (float)(double)local_8;
		      if ((uVar11 & 1) != 0) {
		        fVar3 = (float)(double)local_8 + 1.0;
		      }
		    }
		    else {
		      fVar3 = FLOOR(fVar3 + 0.5);
		    }
		  }
		  else if (dVar7 == -0.5) {
		    if (ABS((double)local_8) < 9.223372036854776e+18) {
		      uVar11 = (ulonglong)(double)local_8;
		    }
		    else {
		      uVar11 = 0;
		    }
		    fVar3 = (float)(double)local_8;
		    if ((uVar11 & 1) != 0) {
		      fVar3 = (float)(double)local_8 + -1.0;
		    }
		  }
		  else {
		    fVar3 = CEIL(fVar3 + -0.5);
		  }
		  uVar4 = unnamed_function_1417(Utils_BackTime_TypeInfo);
		  Core_Extensions_Dict_DictExt__BinarySearch_object__uint_(uVar4,fVar3,0);
		  iVar10 = unnamed_function_1417
		                     (Gameplay_EndlessPaymentOptionsList_Model_EndlessPaymentOptionListData_TypeInfo
		                     );
		  *(undefined4 *)(iVar10 + 0xc) = uVar4;
		  *(int *)(iVar10 + 8) = iVar9;
		  *param2 = iVar10;
		  *(int *)(param1 + 0x28) = iVar10;
		  return 1;
		}
		*/

			return null;
		}

		// Token: 0x060031E3 RID: 12771 RVA: 0x0000A2A8 File Offset: 0x000084A8
		[Token(Token = "0x60031E3")]
		[Address(RVA = "0x8239", Offset = "0x8239", VA = "0x8239")]
		public bool TryGetCurrentList(out EndlessPaymentOptionListData result)
		{
		/* --- GHIDRA: TryGetCurrentList ---
		uint Gameplay_EndlessPaymentOptionsList_Model_EndlessPaymentOptionsListModel__TryGetCurrentList
		               (int param1,undefined4 param2,int *param3,undefined4 param4)
		
		{
		  int iVar1;
		  undefined4 param1_00;
		  undefined4 param1_01;
		  
		  if (DAT_ram_00a57653 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_SingleOrDefault_CardData___);
		    Mono_Security_ASN1__get_Item(&System_Func_CardData__bool__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_EndlessPaymentOptionsList_Model_EndlessPaymentOptionsListModel___c__DisplayClass49_0__TryGetCard_b__0__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Gameplay_EndlessPaymentOptionsList_Model_EndlessPaymentOptionsListModel___c__DisplayClass49_0_TypeInfo
		              );
		    DAT_ram_00a57653 = '\x01';
		  }
		  iVar1 = unnamed_function_1417
		                    (
		                    Gameplay_EndlessPaymentOptionsList_Model_EndlessPaymentOptionsListModel___c__DisplayClass49_0_TypeInfo
		                    );
		  *(undefined4 *)(iVar1 + 8) = param2;
		  param1_01 = *(undefined4 *)(param1 + 0x24);
		  param1_00 = unnamed_function_1417(System_Func_CardData__bool__TypeInfo);
		  System_Collections_Generic_Dictionary_uint__object___GetEnumerator
		            (param1_00,iVar1,
		             Method_Gameplay_EndlessPaymentOptionsList_Model_EndlessPaymentOptionsListModel___c__DisplayClass49_0__TryGetCard_b__0__
		             ,0);
		  iVar1 = UI_SimpleIconValue__set_Value
		                    (param1_01,param1_00,Method_System_Linq_Enumerable_SingleOrDefault_CardData___);
		  *param3 = iVar1;
		  return (uint)(iVar1 != 0);
		}
		*/

			return default(bool);
		}

		// Token: 0x060031E4 RID: 12772 RVA: 0x0000A2C0 File Offset: 0x000084C0
		[Token(Token = "0x60031E4")]
		[Address(RVA = "0x823A", Offset = "0x823A", VA = "0x823A")]
		public bool TryGetCard(BankOptionData option, out CardData result)
		{
			return default(bool);
		}

		// Token: 0x060031E5 RID: 12773 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60031E5")]
		[Address(RVA = "0x823B", Offset = "0x823B", VA = "0x823B")]
		public void ResetList()
		{
		/* --- GHIDRA: ResetList ---
		uint Gameplay_EndlessPaymentOptionsList_Model_EndlessPaymentOptionsListModel__ResetList
		               (int param1,int param2,undefined4 param3)
		
		{
		  return (uint)(*(int *)(param2 + 0xc) == *(int *)(*(int *)(param1 + 0x30) + 0x10));
		}
		*/

		}

		// Token: 0x04001B50 RID: 6992
		[Token(Token = "0x4001B50")]
		[FieldOffset(Offset = "0xC")]
		public readonly IDictProvider DictProvider;

		// Token: 0x04001B51 RID: 6993
		[Token(Token = "0x4001B51")]
		[FieldOffset(Offset = "0x10")]
		public readonly IGame Game;

		// Token: 0x04001B52 RID: 6994
		[Token(Token = "0x4001B52")]
		[FieldOffset(Offset = "0x14")]
		public readonly BankManager Bank;

		// Token: 0x04001B53 RID: 6995
		[Token(Token = "0x4001B53")]
		[FieldOffset(Offset = "0x18")]
		public readonly int MultipleLobbyVisitForEntryPointWidget;

		// Token: 0x04001B54 RID: 6996
		[Token(Token = "0x4001B54")]
		[FieldOffset(Offset = "0x1C")]
		private readonly ICurrentTimeProvider _currentTimeProvider;

		// Token: 0x04001B55 RID: 6997
		[Token(Token = "0x4001B55")]
		[FieldOffset(Offset = "0x20")]
		private readonly int _minDisplayOptionCount;

		// Token: 0x04001B56 RID: 6998
		[Token(Token = "0x4001B56")]
		[FieldOffset(Offset = "0x24")]
		private readonly List<CardData> _cards;

		// Token: 0x04001B57 RID: 6999
		[Token(Token = "0x4001B57")]
		[FieldOffset(Offset = "0x28")]
		private EndlessPaymentOptionListData _currentList;

		// Token: 0x04001B58 RID: 7000
		[Token(Token = "0x4001B58")]
		[FieldOffset(Offset = "0x2C")]
		private bool _isDiscountEnabled;

		// Token: 0x04001B59 RID: 7001
		[Token(Token = "0x4001B59")]
		[FieldOffset(Offset = "0x30")]
		private ProtoGetEndlessPaymentOptionsAns _optionInfos;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_IsDiscountEnabled ---
		void Gameplay_EndlessPaymentOptionsList_Model_EndlessPaymentOptionsListModel__get_IsDiscountEnabled
		               (int param1,uint param2,undefined4 param3)
		
		{
		  if (param2 != *(byte *)(param1 + 0x2c)) {
		    *(char *)(param1 + 0x2c) = (char)param2;
		    Gameplay_EndlessPaymentOptionsList_Model_EndlessPaymentOptionsListModel___ctor(param1,param1);
		  }
		  return;
		}
		*/


		/* --- GHIDRA: get_LastList ---
		uint Gameplay_EndlessPaymentOptionsList_Model_EndlessPaymentOptionsListModel__get_LastList
		               (undefined4 param1,undefined4 param2)
		
		{
		  int iVar1;
		  uint uVar2;
		  undefined1 auStack_10 [12];
		  undefined1 auStack_4 [4];
		  
		  uVar2 = 0;
		  if (DAT_ram_00a57647 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_CardData__get_Count__);
		    DAT_ram_00a57647 = '\x01';
		  }
		  iVar1 = Gameplay_EndlessPaymentOptionsList_Model_EndlessPaymentOptionsListModel__GetCardForDisplay
		                    (param1,auStack_4,auStack_10);
		  if (iVar1 != 0) {
		    iVar1 = Gameplay_EndlessPaymentOptionsList_Model_EndlessPaymentOptionsListModel__ReLink
		                      (param1,auStack_10);
		    uVar2 = (uint)(*(int *)(iVar1 + 0xc) != 0);
		  }
		  return uVar2;
		}
		*/


		/* --- GHIDRA: get_IsAvail ---
		uint Gameplay_EndlessPaymentOptionsList_Model_EndlessPaymentOptionsListModel__get_IsAvail
		               (undefined4 param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 param1_00;
		  uint uVar2;
		  undefined1 auStack_10 [12];
		  undefined1 auStack_4 [4];
		  
		  if (DAT_ram_00a57648 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_CardData__get_Item__);
		    DAT_ram_00a57648 = '\x01';
		  }
		  if (DAT_ram_00a57647 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_CardData__get_Count__);
		    DAT_ram_00a57647 = '\x01';
		  }
		  iVar1 = Gameplay_EndlessPaymentOptionsList_Model_EndlessPaymentOptionsListModel__GetCardForDisplay
		                    (param1,auStack_4,auStack_10);
		  if (iVar1 == 0) {
		    uVar2 = 0;
		  }
		  else {
		    iVar1 = Gameplay_EndlessPaymentOptionsList_Model_EndlessPaymentOptionsListModel__ReLink
		                      (param1,auStack_10);
		    if (*(int *)(iVar1 + 0xc) == 0) {
		      uVar2 = 0;
		    }
		    else {
		      param1_00 = Gameplay_EndlessPaymentOptionsList_Model_EndlessPaymentOptionsListModel__ReLink
		                            (param1,auStack_10);
		      iVar1 = System_Linq_Enumerable__ToList_object_
		                        (param1_00,0,Method_System_Collections_Generic_List_CardData__get_Item__);
		      uVar2 = (uint)(*(double *)(*(int *)(*(int *)(iVar1 + 0x10) + 0x18) + 8) <= 0.0);
		    }
		  }
		  return uVar2;
		}
		*/


		/* --- GHIDRA: get_AllCards ---
		void Gameplay_EndlessPaymentOptionsList_Model_EndlessPaymentOptionsListModel__get_AllCards
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4,undefined4 param5,
		               undefined4 param6,undefined4 param7,undefined4 param8,undefined4 param9)
		
		{
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a57649 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_CardData___ctor__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_List_CardData__TypeInfo);
		    DAT_ram_00a57649 = '\x01';
		  }
		  param1_00 = unnamed_function_1417(System_Collections_Generic_List_CardData__TypeInfo);
		  GAFInternal_Objects_GAFBakedObjectImpl__get_isVisible
		            (param1_00,Method_System_Collections_Generic_List_CardData___ctor__);
		  *(undefined4 *)(param1 + 0x24) = param1_00;
		  Unity_Services_Core_Environments_Internal_Environments__get_Current(param1,param8,0);
		  *(undefined4 *)(param1 + 0x20) = param3;
		  *(undefined4 *)(param1 + 0x18) = param2;
		  *(undefined4 *)(param1 + 0x1c) = param5;
		  *(undefined4 *)(param1 + 0x10) = param4;
		  *(undefined4 *)(param1 + 0x14) = param7;
		  *(undefined4 *)(param1 + 0xc) = param6;
		  return;
		}
		*/

}
