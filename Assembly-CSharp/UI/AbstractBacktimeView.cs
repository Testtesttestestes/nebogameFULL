using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using Utils;

namespace UI
{
	// Token: 0x020000E7 RID: 231
	[Token(Token = "0x20000E7")]
	public abstract class AbstractBacktimeView : MonoBehaviour
	{
		// Token: 0x170000E7 RID: 231
		// (get) Token: 0x060007C3 RID: 1987 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060007C4 RID: 1988 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000E7")]
		public AbstractBacktimeView.FormatCallback FormatBackTimeCallback
		{
			[Token(Token = "0x60007C3")]
			[Address(RVA = "0x5B93", Offset = "0x5B93", VA = "0x5B93")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60007C4")]
			[Address(RVA = "0x5B94", Offset = "0x5B94", VA = "0x5B94")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x060007C5 RID: 1989
		[Token(Token = "0x60007C5")]
		protected abstract void RenderValue(string text);

		// Token: 0x060007C6 RID: 1990 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60007C6")]
		[Address(RVA = "0x5B95", Offset = "0x5B95", VA = "0x5B95")]
		public void SetCustomStaticText(string text)
		{
		}

		// Token: 0x170000E8 RID: 232
		// (get) Token: 0x060007C7 RID: 1991 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060007C8 RID: 1992 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000E8")]
		public BackTime BackTime
		{
			[Token(Token = "0x60007C7")]
			[Address(RVA = "0x5B96", Offset = "0x5B96", VA = "0x5B96")]
			get
			{
				return null;
			}
			[Token(Token = "0x60007C8")]
			[Address(RVA = "0x1B54", Offset = "0x1B54", VA = "0x1B54")]
			set
			{
			}
		}

		// Token: 0x060007C9 RID: 1993 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60007C9")]
		[Address(RVA = "0x5B97", Offset = "0x5B97", VA = "0x5B97")]
		private IEnumerator DisplayCurrentBackTime()
		{
		/* --- GHIDRA: DisplayCurrentBackTime ---
		void UI_AbstractBacktimeView__DisplayCurrentBackTime
		               (int *param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 in_register_20000004;
		  undefined8 uVar1;
		  float fVar3;
		  undefined4 uVar4;
		  int iVar5;
		  double param1_00;
		  undefined4 uVar2;
		  
		  if (DAT_ram_00a5b862 == '\0') {
		    Mono_Security_ASN1__get_Item(&Utils_TimeUtils_TypeInfo);
		    DAT_ram_00a5b862 = '\x01';
		  }
		  iVar5 = param1[5];
		  fVar3 = func_ii_7103(param2,0);
		  if (iVar5 == 0) {
		    if (*(int *)(Utils_TimeUtils_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Utils_TimeUtils_TypeInfo);
		    }
		    param1_00 = (double)fVar3;
		    uVar4 = Utils_TimeUtils__DateFormat(param1_00,0);
		    uVar2 = (undefined4)((ulonglong)param1_00 >> 0x20);
		  }
		  else {
		    uVar1 = CONCAT44(in_register_20000004,*(undefined4 *)(iVar5 + 0x20));
		    uVar4 = (**(code **)((ulonglong)*(uint *)(iVar5 + 0xc) * 4))
		                      (uVar1,fVar3,*(undefined4 *)(iVar5 + 0x14));
		    uVar2 = (undefined4)((ulonglong)uVar1 >> 0x20);
		  }
		  (**(code **)((ulonglong)*(uint *)(*param1 + 0xe0) * 4))
		            (CONCAT44(uVar2,param1),uVar4,*(undefined4 *)(*param1 + 0xe4));
		  return;
		}
		*/

			return null;
		}

		// Token: 0x060007CA RID: 1994 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60007CA")]
		[Address(RVA = "0x5B98", Offset = "0x5B98", VA = "0x5B98")]
		public void Display(BackTime backtime)
		{
		}

		// Token: 0x060007CB RID: 1995 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60007CB")]
		[Address(RVA = "0x5B99", Offset = "0x5B99", VA = "0x5B99")]
		private void StopCurrentCoroutine()
		{
		/* --- GHIDRA: StopCurrentCoroutine ---
		void UI_AbstractBacktimeView__StopCurrentCoroutine(int param1,undefined4 param2)
		
		{
		  int param1_00;
		  undefined4 uVar1;
		  
		  *(undefined4 *)(param1 + 0x18) = 0;
		  if (*(int *)(param1 + 0x1c) != 0) {
		    func_ii_7950(*(int *)(param1 + 0x1c),0);
		    *(undefined4 *)(param1 + 0x1c) = 0;
		    if (*(int *)(param1 + 0x18) != 0) {
		      if (DAT_ram_00a5b861 == '\0') {
		        Mono_Security_ASN1__get_Item
		                  (&UI_AbstractBacktimeView__DisplayCurrentBackTime_d__13_TypeInfo);
		        DAT_ram_00a5b861 = '\x01';
		      }
		      param1_00 = unnamed_function_1417
		                            (UI_AbstractBacktimeView__DisplayCurrentBackTime_d__13_TypeInfo);
		      *(int *)(param1_00 + 0x10) = param1;
		      *(undefined4 *)(param1_00 + 8) = 0;
		      uVar1 = Utils_CoroutineSource__GetMono(param1_00,0);
		      *(undefined4 *)(param1 + 0x1c) = uVar1;
		    }
		  }
		  return;
		}
		*/

		}

		// Token: 0x060007CC RID: 1996 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60007CC")]
		[Address(RVA = "0x5B9A", Offset = "0x5B9A", VA = "0x5B9A")]
		private void OnDestroy()
		{
		}

		// Token: 0x060007CD RID: 1997 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60007CD")]
		[Address(RVA = "0x5B9B", Offset = "0x5B9B", VA = "0x5B9B")]
		protected AbstractBacktimeView()
		{
		/* --- GHIDRA: .ctor ---
		void UI_AbstractBacktimeView___ctor(int param1,int param2,int param3,undefined4 param4)
		
		{
		  char cVar1;
		  int iVar2;
		  undefined4 uVar3;
		  
		  uVar3 = *(undefined4 *)(param3 + 4);
		  *(int *)(param1 + 0x14) = param3;
		  *(undefined4 *)(param1 + 8) = uVar3;
		  *(int *)(param1 + 0x10) = param2;
		  cVar1 = *(char *)(param3 + 0x2e);
		  *(int *)(param1 + 0x20) = param1;
		  iVar2 = func_ii_4538(param3);
		  if (iVar2 == 0) {
		    if (param2 == 0) {
		      uVar3 = Mono_Unity_CertHelper__AddCertificatesToNativeChain
		                        (0,s_Delegate_to_an_instance_method_c_ram_0005d205);
		      func_ii_1050(uVar3,0);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    *(undefined4 *)(param1 + 0xc) = *(undefined4 *)(param1 + 8);
		    *(undefined4 *)(param1 + 0x20) = *(undefined4 *)(param1 + 0x10);
		  }
		  else if (cVar1 == '\x01') {
		    *(char **)(param1 + 0xc) = s_struct_Uniforms___color__array<v_ram_0000223f + 0x165;
		  }
		  else {
		    *(undefined4 *)(param1 + 0xc) = *(undefined4 *)(param1 + 8);
		    *(undefined4 *)(param1 + 0x20) = *(undefined4 *)(param1 + 0x10);
		  }
		  *(char **)(param1 + 0x1c) = s_struct_Uniforms___color__array<v_ram_0000223f + 0x166;
		  return;
		}
		*/

		}

		// Token: 0x040002AE RID: 686
		[Token(Token = "0x40002AE")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private bool _hideZeroTimer;

		// Token: 0x040002B0 RID: 688
		[Token(Token = "0x40002B0")]
		[FieldOffset(Offset = "0x18")]
		private BackTime _backTime;

		// Token: 0x040002B1 RID: 689
		[Token(Token = "0x40002B1")]
		[FieldOffset(Offset = "0x1C")]
		private Coroutine _displayBackTimeCoroutine;

		// Token: 0x020000E8 RID: 232
		// (Invoke) Token: 0x060007CF RID: 1999
		[Token(Token = "0x20000E8")]
		public delegate string FormatCallback(float value);
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: set_FormatBackTimeCallback ---
		void UI_AbstractBacktimeView__set_FormatBackTimeCallback
		               (int *param1,undefined4 param2,undefined4 param3)
		
		{
		  if (param1[7] != 0) {
		    func_ii_7950(param1[7],0);
		    param1[7] = 0;
		  }
		  (**(code **)((ulonglong)*(uint *)(*param1 + 0xe0) * 4))
		            (param1,param2,*(undefined4 *)(*param1 + 0xe4));
		  return;
		}
		*/


		/* --- GHIDRA: get_BackTime ---
		int UI_AbstractBacktimeView__get_BackTime(undefined4 param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  if (DAT_ram_00a5b861 == '\0') {
		    Mono_Security_ASN1__get_Item(&UI_AbstractBacktimeView__DisplayCurrentBackTime_d__13_TypeInfo);
		    DAT_ram_00a5b861 = '\x01';
		  }
		  iVar1 = unnamed_function_1417(UI_AbstractBacktimeView__DisplayCurrentBackTime_d__13_TypeInfo);
		  *(undefined4 *)(iVar1 + 0x10) = param1;
		  *(undefined4 *)(iVar1 + 8) = 0;
		  return iVar1;
		}
		*/


		/* --- GHIDRA: set_BackTime ---
		void UI_AbstractBacktimeView__set_BackTime(int param1,int *param2,undefined4 param3)
		
		{
		  bool bVar1;
		  uint uVar2;
		  int iVar3;
		  undefined4 uVar4;
		  int *piVar5;
		  uint *puVar6;
		  undefined4 *puVar7;
		  int iVar8;
		  int iVar9;
		  int iVar10;
		  undefined4 uVar11;
		  undefined4 uVar12;
		  int *piVar13;
		  int local_24;
		  int **ppiStack_20;
		  undefined8 local_1c;
		  int *local_14;
		  undefined8 local_10;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a57a48 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               System_Action_BossInfo_BossAttackOption__BossInfo_BossAttackOption_BossAttackOptionVariant__TypeInfo
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Boss_View_CaptainTab_BossInfoView_OptionViewOnAttackButtonClickEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_Enumerator_BossAttackOptionView__Dispose__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_Enumerator_BossAttackOptionView__MoveNext__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_List_Enumerator_BossAttackOptionView__get_Current__
		              );
		    Mono_Security_ASN1__get_Item(&System_IDisposable_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&System_Collections_Generic_IEnumerable_BossInfo_BossAttackOption__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&System_Collections_Generic_IEnumerator_BossInfo_BossAttackOption__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_IEnumerator_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_BossAttackOptionView__Add__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_BossAttackOptionView__Clear__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_BossAttackOptionView__GetEnumerator__);
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_Object_Instantiate_BossAttackOptionView___);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Object_TypeInfo);
		    DAT_ram_00a57a48 = '\x01';
		  }
		  local_8 = 0;
		  local_10 = 0;
		  local_14 = (int *)0x0;
		  System_Collections_Generic_List_RegexCharClass_SingleRange___ForEach
		            (&local_24,*(undefined4 *)(param1 + 0x3c),
		             Method_System_Collections_Generic_List_BossAttackOptionView__GetEnumerator__);
		  local_8 = local_1c;
		  local_24 = 0;
		  ppiStack_20 = (int **)&local_10;
		  do {
		    DAT_ram_009d3e38 = 0;
		    iVar3 = import::env::invoke_iii
		                      (s_struct_Uniforms___color__array<v_ram_00000aff + 0x44,&local_10,
		                       Method_System_Collections_Generic_List_Enumerator_BossAttackOptionView__MoveNext__
		                      );
		    iVar10 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar10 == 1) {
		      uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80e170d8;
		    }
		    if (iVar3 == 0) goto code_r0x80e1717b;
		    DAT_ram_009d3e38 = 0;
		    iVar10 = local_8._4_4_;
		    uVar4 = import::env::invoke_ii
		                      (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x199,
		                       System_Action_BossInfo_BossAttackOption__BossInfo_BossAttackOption_BossAttackOptionVariant__TypeInfo
		                      );
		    if (DAT_ram_009d3e38 == 1) {
		code_r0x80e170d0:
		      DAT_ram_009d3e38 = 0;
		      uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80e170d8;
		    }
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_viiii
		              (s_struct_Uniforms___color__array<v_ram_000017c8 + 0x37e,uVar4,param1,
		               Method_Gameplay_Boss_View_CaptainTab_BossInfoView_OptionViewOnAttackButtonClickEvent__
		               ,0);
		    if (DAT_ram_009d3e38 == 1) goto code_r0x80e170d0;
		    if (DAT_ram_00a57a34 == '\0') {
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_vi
		                (0x7ff,&
		                       System_Action_BossInfo_BossAttackOption__BossInfo_BossAttackOption_BossAttackOptionVariant__TypeInfo
		                );
		      if (DAT_ram_009d3e38 == 1) goto code_r0x80e170d0;
		      DAT_ram_00a57a34 = '\x01';
		    }
		    iVar3 = *(int *)(iVar10 + 0x2c);
		    do {
		      DAT_ram_009d3e38 = 0;
		      iVar8 = import::env::invoke_iiii
		                        (s_struct_Uniforms___color__array<v_ram_00001b87 + 2,iVar3,uVar4,0);
		      uVar11 = 
		      System_Action_BossInfo_BossAttackOption__BossInfo_BossAttackOption_BossAttackOptionVariant__TypeInfo
		      ;
		      if (DAT_ram_009d3e38 == 1) {
		code_r0x80e170bc:
		        DAT_ram_009d3e38 = 0;
		        uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x80e170d8;
		      }
		      if (iVar8 == 0) {
		        iVar9 = 0;
		      }
		      else {
		        DAT_ram_009d3e38 = 0;
		        iVar9 = import::env::invoke_iii
		                          (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x1a,iVar8,
		                           System_Action_BossInfo_BossAttackOption__BossInfo_BossAttackOption_BossAttackOptionVariant__TypeInfo
		                          );
		        if (DAT_ram_009d3e38 == 1) goto code_r0x80e170bc;
		        if (iVar9 == 0) {
		          DAT_ram_009d3e38 = 0;
		          import::env::invoke_vii
		                    (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x183,iVar8,uVar11);
		          iVar10 = DAT_ram_009d3e38;
		          DAT_ram_009d3e38 = 0;
		          if (iVar10 != 1) goto code_r0x80e17888;
		          uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          goto code_r0x80e170d8;
		        }
		      }
		      DAT_ram_009d3e38 = 0;
		      iVar8 = func_ii_4329(iVar10 + 0x2c,iVar9,iVar3);
		      if (DAT_ram_009d3e38 == 1) goto code_r0x80e170bc;
		      bVar1 = iVar3 != iVar8;
		      iVar3 = iVar8;
		    } while (bVar1);
		    DAT_ram_009d3e38 = 0;
		    uVar4 = import::env::invoke_iii
		                      (s_struct_Uniforms___color__array<v_ram_00000aff + 0x25c,iVar10,0);
		    if (DAT_ram_009d3e38 == 1) break;
		    if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_vi
		                (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x180,UnityEngine_Object_TypeInfo
		                );
		      if (DAT_ram_009d3e38 == 1) break;
		    }
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_vii(s_struct_Uniforms___color__array<v_ram_00000aff + 0x274,uVar4,0);
		  } while (DAT_ram_009d3e38 != 1);
		  DAT_ram_009d3e38 = 0;
		  uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x80e170d8:
		  iVar10 = global_1;
		  iVar3 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		  if (iVar10 == iVar3) {
		    piVar5 = (int *)import::env::__cxa_begin_catch(uVar4);
		    iVar3 = *piVar5;
		    DAT_ram_009d3e38 = 0;
		    local_24 = iVar3;
		    import::env::invoke_v(0x123);
		    iVar10 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar10 != 1) {
		      if (iVar3 != 0) {
		        System_Data_DataSet__ValidateLocaleConstraint(iVar3);
		        do {
		          halt_trap();
		        } while( true );
		      }
		code_r0x80e1717b:
		      DAT_ram_009d3e38 = 0;
		      iVar10 = *(int *)(param1 + 0x3c);
		      iVar3 = *(int *)(iVar10 + 0xc);
		      *(undefined4 *)(iVar10 + 0xc) = 0;
		      *(int *)(iVar10 + 0x10) = *(int *)(iVar10 + 0x10) + 1;
		      if (0 < iVar3) {
		        func_ii_2064(*(undefined4 *)(iVar10 + 8),0,iVar3,0);
		      }
		      if (param2 == (int *)0x0) {
		        return;
		      }
		      uVar2 = 0;
		      iVar10 = *param2;
		      if (*(ushort *)(iVar10 + 0xb6) != 0) {
		        do {
		          if (System_Collections_Generic_IEnumerable_BossInfo_BossAttackOption__TypeInfo ==
		              *(int *)(*(int *)(iVar10 + 0x58) + uVar2 * 8)) {
		            puVar6 = (uint *)(iVar10 + *(int *)(*(int *)(iVar10 + 0x58) + uVar2 * 8 + 4) * 8 + 0xc0)
		            ;
		            goto code_r0x80e1722b;
		          }
		          uVar2 = uVar2 + 1;
		        } while (*(ushort *)(iVar10 + 0xb6) != uVar2);
		      }
		      puVar6 = (uint *)func_ii_1080(param2,
		                                    System_Collections_Generic_IEnumerable_BossInfo_BossAttackOption__TypeInfo
		                                    ,0);
		code_r0x80e1722b:
		      local_14 = (int *)(**(code **)((ulonglong)*puVar6 * 4))(param2,puVar6[1]);
		      local_24 = 0;
		      ppiStack_20 = &local_14;
		      do {
		        piVar5 = local_14;
		        iVar10 = *local_14;
		        if (*(ushort *)(iVar10 + 0xb6) != 0) {
		          uVar2 = 0;
		          do {
		            piVar13 = (int *)(*(int *)(iVar10 + 0x58) + uVar2 * 8);
		            if (System_Collections_IEnumerator_TypeInfo == *piVar13) {
		              puVar7 = (undefined4 *)(iVar10 + piVar13[1] * 8 + 0xc0);
		              goto code_r0x80e172fb;
		            }
		            uVar2 = uVar2 + 1;
		          } while (*(ushort *)(iVar10 + 0xb6) != uVar2);
		        }
		        DAT_ram_009d3e38 = 0;
		        puVar7 = (undefined4 *)
		                 import::env::invoke_iiii
		                           (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_14,
		                            System_Collections_IEnumerator_TypeInfo,0);
		        if (DAT_ram_009d3e38 == 1) {
		code_r0x80e1733f:
		          DAT_ram_009d3e38 = 0;
		          uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          goto code_r0x80e17756;
		        }
		code_r0x80e172fb:
		        DAT_ram_009d3e38 = 0;
		        iVar10 = import::env::invoke_iii(*puVar7,piVar5,puVar7[1]);
		        piVar5 = local_14;
		        if (DAT_ram_009d3e38 == 1) goto code_r0x80e1733f;
		        if (iVar10 == 0) goto code_r0x80e1779f;
		        iVar10 = *local_14;
		        if (*(ushort *)(iVar10 + 0xb6) != 0) {
		          uVar2 = 0;
		          do {
		            piVar13 = (int *)(*(int *)(iVar10 + 0x58) + uVar2 * 8);
		            if (System_Collections_Generic_IEnumerator_BossInfo_BossAttackOption__TypeInfo ==
		                *piVar13) {
		              puVar7 = (undefined4 *)(iVar10 + piVar13[1] * 8 + 0xc0);
		              goto code_r0x80e173e2;
		            }
		            uVar2 = uVar2 + 1;
		          } while (*(ushort *)(iVar10 + 0xb6) != uVar2);
		        }
		        DAT_ram_009d3e38 = 0;
		        puVar7 = (undefined4 *)
		                 import::env::invoke_iiii
		                           (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_14,
		                            System_Collections_Generic_IEnumerator_BossInfo_BossAttackOption__TypeInfo
		                            ,0);
		        if (DAT_ram_009d3e38 == 1) {
		code_r0x80e1774e:
		          DAT_ram_009d3e38 = 0;
		          uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          goto code_r0x80e17756;
		        }
		code_r0x80e173e2:
		        DAT_ram_009d3e38 = 0;
		        uVar4 = import::env::invoke_iii(*puVar7,piVar5,puVar7[1]);
		        if (DAT_ram_009d3e38 == 1) goto code_r0x80e1774e;
		        uVar11 = *(undefined4 *)(param1 + 0x28);
		        uVar12 = *(undefined4 *)(param1 + 0x38);
		        if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		          DAT_ram_009d3e38 = 0;
		          import::env::invoke_vi
		                    (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x180,
		                     UnityEngine_Object_TypeInfo);
		          iVar10 = DAT_ram_009d3e38;
		          DAT_ram_009d3e38 = 0;
		          if (iVar10 == 1) {
		            uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		            goto code_r0x80e17756;
		          }
		        }
		        DAT_ram_009d3e38 = 0;
		        iVar8 = import::env::invoke_iiii
		                          (s_struct_Uniforms___color__array<v_ram_000017c8 + 0x2ce,uVar12,uVar11,
		                           Method_UnityEngine_Object_Instantiate_BossAttackOptionView___);
		        iVar3 = DAT_ram_009d3e38;
		        iVar10 = Method_System_Collections_Generic_List_BossAttackOptionView__Add__;
		        DAT_ram_009d3e38 = 0;
		        if (iVar3 == 1) {
		          uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          goto code_r0x80e17756;
		        }
		        iVar3 = *(int *)(param1 + 0x3c);
		        *(int *)(iVar3 + 0x10) = *(int *)(iVar3 + 0x10) + 1;
		        uVar2 = *(uint *)(iVar3 + 0xc);
		        if (uVar2 < *(uint *)(*(int *)(iVar3 + 8) + 0xc)) {
		          *(uint *)(iVar3 + 0xc) = uVar2 + 1;
		          *(int *)(*(int *)(iVar3 + 8) + uVar2 * 4 + 0x10) = iVar8;
		        }
		        else {
		          DAT_ram_009d3e38 = 0;
		          import::env::invoke_viii
		                    (s_struct_Uniforms___color__array<v_ram_00000aff + 0x6e,iVar3,iVar8,
		                     *(undefined4 *)(*(int *)(*(int *)(iVar10 + 0x10) + 0x60) + 0x38));
		          iVar10 = DAT_ram_009d3e38;
		          DAT_ram_009d3e38 = 0;
		          if (iVar10 == 1) {
		            uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		            goto code_r0x80e17756;
		          }
		        }
		        DAT_ram_009d3e38 = 0;
		        uVar11 = import::env::invoke_ii
		                           (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x199,
		                            System_Action_BossInfo_BossAttackOption__BossInfo_BossAttackOption_BossAttackOptionVariant__TypeInfo
		                           );
		        if (DAT_ram_009d3e38 == 1) {
		code_r0x80e17726:
		          DAT_ram_009d3e38 = 0;
		          uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          goto code_r0x80e17756;
		        }
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_viiii
		                  (s_struct_Uniforms___color__array<v_ram_000017c8 + 0x37e,uVar11,param1,
		                   Method_Gameplay_Boss_View_CaptainTab_BossInfoView_OptionViewOnAttackButtonClickEvent__
		                   ,0);
		        if (DAT_ram_009d3e38 == 1) goto code_r0x80e17726;
		        if (DAT_ram_00a57a33 == '\0') {
		          DAT_ram_009d3e38 = 0;
		          import::env::invoke_vi
		                    (0x7ff,&
		                           System_Action_BossInfo_BossAttackOption__BossInfo_BossAttackOption_BossAttackOptionVariant__TypeInfo
		                    );
		          if (DAT_ram_009d3e38 == 1) goto code_r0x80e17726;
		          DAT_ram_00a57a33 = '\x01';
		        }
		        iVar10 = *(int *)(iVar8 + 0x2c);
		        do {
		          DAT_ram_009d3e38 = 0;
		          iVar3 = import::env::invoke_iiii
		                            (s_struct_Uniforms___color__array<v_ram_00001b87 + 5,iVar10,uVar11,0);
		          uVar12 = 
		          System_Action_BossInfo_BossAttackOption__BossInfo_BossAttackOption_BossAttackOptionVariant__TypeInfo
		          ;
		          if (DAT_ram_009d3e38 == 1) {
		code_r0x80e1771c:
		            DAT_ram_009d3e38 = 0;
		            uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		            goto code_r0x80e17756;
		          }
		          if (iVar3 == 0) {
		            iVar9 = 0;
		          }
		          else {
		            DAT_ram_009d3e38 = 0;
		            iVar9 = import::env::invoke_iii
		                              (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x1a,iVar3,
		                               System_Action_BossInfo_BossAttackOption__BossInfo_BossAttackOption_BossAttackOptionVariant__TypeInfo
		                              );
		            if (DAT_ram_009d3e38 == 1) goto code_r0x80e1771c;
		            if (iVar9 == 0) {
		              DAT_ram_009d3e38 = 0;
		              import::env::invoke_vii
		                        (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x183,iVar3,uVar12);
		              iVar10 = DAT_ram_009d3e38;
		              DAT_ram_009d3e38 = 0;
		              if (iVar10 != 1) {
		code_r0x80e17888:
		                do {
		                  halt_trap();
		                } while( true );
		              }
		              uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		              goto code_r0x80e17756;
		            }
		          }
		          DAT_ram_009d3e38 = 0;
		          iVar3 = func_ii_4329(iVar8 + 0x2c,iVar9,iVar10);
		          if (DAT_ram_009d3e38 == 1) goto code_r0x80e1771c;
		          bVar1 = iVar10 != iVar3;
		          iVar10 = iVar3;
		        } while (bVar1);
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_viii
		                  (s_struct_Uniforms___color__array<v_ram_00001b87 + 0x1d,iVar8,uVar4,iVar3);
		        iVar10 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		      } while (iVar10 != 1);
		      uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x80e17756:
		      iVar10 = global_1;
		      iVar3 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		      if (iVar10 == iVar3) {
		        piVar5 = (int *)import::env::__cxa_begin_catch(uVar4);
		        local_24 = *piVar5;
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_v(0x123);
		        iVar10 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar10 != 1) {
		code_r0x80e1779f:
		          DAT_ram_009d3e38 = 0;
		          piVar5 = *ppiStack_20;
		          if (piVar5 != (int *)0x0) {
		            uVar2 = 0;
		            iVar10 = *piVar5;
		            if (*(ushort *)(iVar10 + 0xb6) != 0) {
		              do {
		                if (System_IDisposable_TypeInfo == *(int *)(*(int *)(iVar10 + 0x58) + uVar2 * 8)) {
		                  puVar6 = (uint *)(iVar10 + *(int *)(*(int *)(iVar10 + 0x58) + uVar2 * 8 + 4) * 8 +
		                                   0xc0);
		                  goto code_r0x80e1781a;
		                }
		                uVar2 = uVar2 + 1;
		              } while (*(ushort *)(iVar10 + 0xb6) != uVar2);
		            }
		            puVar6 = (uint *)func_ii_1080(piVar5,System_IDisposable_TypeInfo,0);
		code_r0x80e1781a:
		            (**(code **)((ulonglong)*puVar6 * 4))(piVar5,puVar6[1]);
		          }
		          if (local_24 == 0) {
		            return;
		          }
		          System_Data_DataSet__ValidateLocaleConstraint(local_24);
		          do {
		            halt_trap();
		          } while( true );
		        }
		        uVar4 = import::env::__cxa_find_matching_catch_2();
		      }
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_00001b87 + 0x1e,&local_24);
		      goto joined_r0x80e1786e;
		    }
		    uVar4 = import::env::__cxa_find_matching_catch_2();
		  }
		  DAT_ram_009d3e38 = 0;
		  import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_00001b87 + 0x1c,&local_24);
		joined_r0x80e1786e:
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
