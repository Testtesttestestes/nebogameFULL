using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using Core.Data;
using Core.Dict;
using Core.Gameplay;
using Core.Gameplay.Managers;
using Il2CppDummyDll;
using MVC;
using Protocol.Dic;

namespace Gameplay.RegisterV2.Model
{
	// Token: 0x0200056A RID: 1386
	[Token(Token = "0x200056A")]
	public class RegisterModel : AbstractModel
	{
		// Token: 0x1700061B RID: 1563
		// (get) Token: 0x06002159 RID: 8537 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700061B")]
		public string NickPattern
		{
			[Token(Token = "0x6002159")]
			[Address(RVA = "0x72BB", Offset = "0x72BB", VA = "0x72BB")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700061C RID: 1564
		// (get) Token: 0x0600215A RID: 8538 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700061C")]
		public List<AprDic> CurrentGenderAprs
		{
			[Token(Token = "0x600215A")]
			[Address(RVA = "0x72BC", Offset = "0x72BC", VA = "0x72BC")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700061D RID: 1565
		// (get) Token: 0x0600215B RID: 8539 RVA: 0x00006A98 File Offset: 0x00004C98
		// (set) Token: 0x0600215C RID: 8540 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700061D")]
		public bool IsRegisterProcessing
		{
			[Token(Token = "0x600215B")]
			[Address(RVA = "0x72BD", Offset = "0x72BD", VA = "0x72BD")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600215C")]
			[Address(RVA = "0x72BE", Offset = "0x72BE", VA = "0x72BE")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x0600215D RID: 8541 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600215D")]
		[Address(RVA = "0x72BF", Offset = "0x72BF", VA = "0x72BF", Slot = "5")]
		public override void Dispose()
		{
		/* --- GHIDRA: Dispose ---
		void Gameplay_RegisterV2_Model_RegisterModel__Dispose
		               (int param1,int *param2,undefined4 param3,undefined4 param4)
		
		{
		  uint uVar1;
		  undefined4 uVar2;
		  uint *puVar3;
		  int *piVar4;
		  undefined4 param1_00;
		  int iVar5;
		  
		  if (DAT_ram_00a58386 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Application_IApp_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_string___ctor__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_List_string__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Text_RegularExpressions_Regex_TypeInfo);
		    DAT_ram_00a58386 = '\x01';
		  }
		  *(undefined4 *)(param1 + 0xc) = 3;
		  uVar2 = unnamed_function_1417(System_Collections_Generic_List_string__TypeInfo);
		  GAFInternal_Objects_GAFBakedObjectImpl__get_isVisible
		            (uVar2,Method_System_Collections_Generic_List_string___ctor__);
		  *(undefined4 *)(param1 + 0x20) = uVar2;
		  Unity_Services_Core_Environments_Internal_Environments__get_Current(param1,param3,0);
		  *(int **)(param1 + 0x34) = param2;
		  iVar5 = *param2;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 0xe0);
		        goto code_r0x80ed6a14;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(param2,Core_Gameplay_IGame_TypeInfo,4);
		code_r0x80ed6a14:
		  piVar4 = (int *)(**(code **)((ulonglong)*puVar3 * 4))(param2,puVar3[1]);
		  uVar1 = 0;
		  iVar5 = *piVar4;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    do {
		      if (Core_Application_IApp_TypeInfo == *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 0x170);
		        goto code_r0x80ed6a94;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(piVar4,Core_Application_IApp_TypeInfo,0x16);
		code_r0x80ed6a94:
		  uVar2 = (**(code **)((ulonglong)*puVar3 * 4))(piVar4,puVar3[1]);
		  *(undefined4 *)(param1 + 0x3c) = uVar2;
		  uVar1 = 0;
		  iVar5 = *param2;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 0xe0);
		        goto code_r0x80ed6b13;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(param2,Core_Gameplay_IGame_TypeInfo,4);
		code_r0x80ed6b13:
		  piVar4 = (int *)(**(code **)((ulonglong)*puVar3 * 4))(param2,puVar3[1]);
		  uVar1 = 0;
		  iVar5 = *piVar4;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    do {
		      if (Core_Application_IApp_TypeInfo == *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 0x160);
		        goto code_r0x80ed6b93;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(piVar4,Core_Application_IApp_TypeInfo,0x14);
		code_r0x80ed6b93:
		  iVar5 = (**(code **)((ulonglong)*puVar3 * 4))(piVar4,puVar3[1]);
		  *(undefined4 *)(param1 + 0x38) = *(undefined4 *)(iVar5 + 0x14);
		  uVar1 = 0;
		  iVar5 = *param2;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 0x178);
		        goto code_r0x80ed6c17;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(param2,Core_Gameplay_IGame_TypeInfo,0x17);
		code_r0x80ed6c17:
		  uVar2 = (**(code **)((ulonglong)*puVar3 * 4))(param2,puVar3[1]);
		  *(undefined4 *)(param1 + 0x10) = uVar2;
		  uVar2 = Gameplay_RegisterV2_View_CultSelector_CultSelectorListArgs___ctor(param1,puVar3);
		  param1_00 = unnamed_function_1417(System_Text_RegularExpressions_Regex_TypeInfo);
		  System_Xml_Schema_FacetsChecker_FacetsCompiler__Preprocess(param1_00,uVar2,0x218,0);
		  *(undefined4 *)(param1 + 0x40) = param1_00;
		  return;
		}
		*/

		}

		// Token: 0x0600215E RID: 8542 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600215E")]
		[Address(RVA = "0x72C0", Offset = "0x72C0", VA = "0x72C0")]
		public RegisterModel(IGame game, UserData user)
		{
		}

		// Token: 0x04001236 RID: 4662
		[Token(Token = "0x4001236")]
		[FieldOffset(Offset = "0xC")]
		public readonly uint PointerId;

		// Token: 0x04001237 RID: 4663
		[Token(Token = "0x4001237")]
		[FieldOffset(Offset = "0x10")]
		public readonly IDictProvider Dict;

		// Token: 0x04001238 RID: 4664
		[Token(Token = "0x4001238")]
		[FieldOffset(Offset = "0x14")]
		public List<CultDic> Cults;

		// Token: 0x04001239 RID: 4665
		[Token(Token = "0x4001239")]
		[FieldOffset(Offset = "0x18")]
		public Dictionary<uint, List<AprDic>> GendersByCults;

		// Token: 0x0400123A RID: 4666
		[Token(Token = "0x400123A")]
		[FieldOffset(Offset = "0x1C")]
		public string CurrentNick;

		// Token: 0x0400123B RID: 4667
		[Token(Token = "0x400123B")]
		[FieldOffset(Offset = "0x20")]
		public List<string> PossibleNicks;

		// Token: 0x0400123C RID: 4668
		[Token(Token = "0x400123C")]
		[FieldOffset(Offset = "0x24")]
		public uint CurrentCult;

		// Token: 0x0400123D RID: 4669
		[Token(Token = "0x400123D")]
		[FieldOffset(Offset = "0x28")]
		public AprDic CurrentApr;

		// Token: 0x0400123E RID: 4670
		[Token(Token = "0x400123E")]
		[FieldOffset(Offset = "0x2C")]
		private string _nickPattern;

		// Token: 0x04001240 RID: 4672
		[Token(Token = "0x4001240")]
		[FieldOffset(Offset = "0x34")]
		public readonly IGame Game;

		// Token: 0x04001241 RID: 4673
		[Token(Token = "0x4001241")]
		[FieldOffset(Offset = "0x38")]
		public readonly IRegistrationProvider RegistrationProvider;

		// Token: 0x04001242 RID: 4674
		[Token(Token = "0x4001242")]
		[FieldOffset(Offset = "0x3C")]
		public readonly IGameResolver GameResolver;

		// Token: 0x04001243 RID: 4675
		[Token(Token = "0x4001243")]
		[FieldOffset(Offset = "0x40")]
		public readonly Regex NickRegex;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_NickPattern ---
		undefined4 Gameplay_RegisterV2_Model_RegisterModel__get_NickPattern(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  
		  if (DAT_ram_00a58384 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_uint__List_AprDic___ContainsKey__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_uint__List_AprDic___get_Item__);
		    DAT_ram_00a58384 = '\x01';
		  }
		  iVar1 = UnityEngine_TextCore_Text_FontAsset__ReadFontAssetDefinition
		                    (*(undefined4 *)(param1 + 0x18),*(undefined4 *)(param1 + 0x24),
		                     Method_System_Collections_Generic_Dictionary_uint__List_AprDic___ContainsKey__)
		  ;
		  if (iVar1 == 0) {
		    uVar2 = 0;
		  }
		  else {
		    uVar2 = System_Collections_Generic_List_object___get_Item
		                      (*(undefined4 *)(param1 + 0x18),*(undefined4 *)(param1 + 0x24),
		                       Method_System_Collections_Generic_Dictionary_uint__List_AprDic___get_Item__);
		  }
		  return uVar2;
		}
		*/


		/* --- GHIDRA: set_IsRegisterProcessing ---
		void Gameplay_RegisterV2_Model_RegisterModel__set_IsRegisterProcessing(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 param1_00;
		  int *piVar2;
		  int iVar3;
		  int local_20;
		  undefined8 *local_1c;
		  undefined8 local_18;
		  undefined8 local_10;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a58385 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_uint__List_AprDic___GetEnumerator__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_Enumerator_uint__List_AprDic___Dispose__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_Enumerator_uint__List_AprDic___MoveNext__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_Enumerator_uint__List_AprDic___get_Current__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_KeyValuePair_uint__List_AprDic___get_Value__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_AprDic__Clear__);
		    DAT_ram_00a58385 = '\x01';
		  }
		  local_8 = 0;
		  local_10 = 0;
		  local_18 = 0;
		  *(undefined4 *)(param1 + 0x14) = 0;
		  System_Collections_Generic_List_object___GetEnumerator
		            (&local_18,*(undefined4 *)(param1 + 0x18),
		             Method_System_Collections_Generic_Dictionary_uint__List_AprDic___GetEnumerator__);
		  local_20 = 0;
		  local_1c = &local_18;
		  do {
		    do {
		      DAT_ram_009d3e38 = 0;
		      iVar1 = import::env::invoke_iii
		                        (s_struct_Uniforms___color__array<v_ram_00000aff + 0x155,&local_18,
		                         Method_System_Collections_Generic_Dictionary_Enumerator_uint__List_AprDic___MoveNext__
		                        );
		      iVar3 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar3 == 1) {
		        param1_00 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x80ed8295;
		      }
		      if (iVar1 == 0) goto code_r0x80ed82eb;
		      iVar3 = *(int *)((int)local_8 + 0xc);
		      *(undefined4 *)((int)local_8 + 0xc) = 0;
		      *(int *)((int)local_8 + 0x10) = *(int *)((int)local_8 + 0x10) + 1;
		    } while (iVar3 < 1);
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_viiii
		              (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x1bc,
		               *(undefined4 *)((int)local_8 + 8),0,iVar3,0);
		    iVar3 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		  } while (iVar3 != 1);
		  param1_00 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x80ed8295:
		  iVar3 = global_1;
		  iVar1 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		  if (iVar3 == iVar1) {
		    piVar2 = (int *)import::env::__cxa_begin_catch(param1_00);
		    iVar1 = *piVar2;
		    DAT_ram_009d3e38 = 0;
		    local_20 = iVar1;
		    import::env::invoke_v(0x123);
		    iVar3 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar3 != 1) {
		      if (iVar1 != 0) {
		        System_Data_DataSet__ValidateLocaleConstraint(iVar1);
		        do {
		          halt_trap();
		        } while( true );
		      }
		code_r0x80ed82eb:
		      DAT_ram_009d3e38 = 0;
		      *(undefined4 *)(param1 + 0x28) = 0;
		      *(undefined4 *)(param1 + 0x20) = 0;
		      *(undefined8 *)(param1 + 0x18) = 0;
		      Core_ExternalIncomingScriptCall_CallbackItem___Il2CppFullySharedGenericType____ctor(param1,0);
		      return;
		    }
		    param1_00 = import::env::__cxa_find_matching_catch_2();
		  }
		  DAT_ram_009d3e38 = 0;
		  import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_00001b87 + 0x150,&local_20);
		  iVar3 = DAT_ram_009d3e38;
		  DAT_ram_009d3e38 = 0;
		  if (iVar3 == 1) {
		    import::env::__cxa_find_matching_catch_3(0);
		    unnamed_function_937();
		    do {
		      halt_trap();
		    } while( true );
		  }
		  import::env::__resumeException(param1_00);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

}
