using System;
using Il2CppDummyDll;

namespace Gameplay.TutorialV2.Controller
{
	// Token: 0x0200043F RID: 1087
	[Token(Token = "0x200043F")]
	public abstract class TutorialStepsQueueBase
	{
		// Token: 0x17000486 RID: 1158
		// (get) Token: 0x060019A1 RID: 6561
		[Token(Token = "0x17000486")]
		public abstract StepActionType StepActionType { [Token(Token = "0x60019A1")] get; }

		// Token: 0x060019A2 RID: 6562 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60019A2")]
		[Address(RVA = "0x1CE0", Offset = "0x1CE0", VA = "0x1CE0")]
		public void ShowNextStep(StepActionType actionType, ICompleteCallback completeCallback)
		{
		/* --- GHIDRA: ShowNextStep ---
		int * Gameplay_TutorialV2_Controller_TutorialStepsQueueBase__ShowNextStep(int *param1)
		
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

		}

		// Token: 0x060019A3 RID: 6563
		[Token(Token = "0x60019A3")]
		protected abstract void ShowNextInternal(StepActionType actionType);

		// Token: 0x060019A4 RID: 6564 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60019A4")]
		[Address(RVA = "0x6B3D", Offset = "0x6B3D", VA = "0x6B3D")]
		private void Unsubscribe(ICompleteCallback callback)
		{
		}

		// Token: 0x060019A5 RID: 6565
		[Token(Token = "0x60019A5")]
		public abstract void Hide();

		// Token: 0x060019A6 RID: 6566 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60019A6")]
		[Address(RVA = "0x6B3E", Offset = "0x6B3E", VA = "0x6B3E")]
		protected TutorialStepsQueueBase()
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_TutorialV2_Controller_TutorialStepsQueueBase___ctor(int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  int iVar2;
		  undefined4 *puVar3;
		  undefined4 param1_00;
		  int *piVar4;
		  int iVar5;
		  int *piVar6;
		  int local_18;
		  undefined8 *local_14;
		  undefined8 local_10;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a583d8 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_TutorialModel__TutorialEvents__TutorialController__TutorialView__Dispose__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_Enumerator_IDisposable__Dispose__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_Enumerator_IDisposable__MoveNext__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_Enumerator_IDisposable__get_Current__);
		    Mono_Security_ASN1__get_Item(&System_IDisposable_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_IDisposable__GetEnumerator__);
		    DAT_ram_00a583d8 = '\x01';
		  }
		  local_8 = 0;
		  local_10 = 0;
		  System_Collections_Generic_List_RegexCharClass_SingleRange___ForEach
		            (&local_10,*(undefined4 *)(param1 + 0x18),
		             Method_System_Collections_Generic_List_IDisposable__GetEnumerator__);
		  local_18 = 0;
		  local_14 = &local_10;
		  do {
		    DAT_ram_009d3e38 = 0;
		    iVar2 = import::env::invoke_iii
		                      (s_struct_Uniforms___color__array<v_ram_00000aff + 0x44,&local_10,
		                       Method_System_Collections_Generic_List_Enumerator_IDisposable__MoveNext__);
		    iVar5 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar5 == 1) {
		      param1_00 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80edf311;
		    }
		    if (iVar2 == 0) goto code_r0x80edf367;
		    piVar4 = local_8._4_4_;
		    iVar5 = *local_8._4_4_;
		    if (*(ushort *)(iVar5 + 0xb6) != 0) {
		      uVar1 = 0;
		      do {
		        piVar6 = (int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8);
		        if (System_IDisposable_TypeInfo == *piVar6) {
		          puVar3 = (undefined4 *)(iVar5 + piVar6[1] * 8 + 0xc0);
		          goto code_r0x80edf2b4;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		    }
		    DAT_ram_009d3e38 = 0;
		    puVar3 = (undefined4 *)
		             import::env::invoke_iiii
		                       (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_8._4_4_,
		                        System_IDisposable_TypeInfo,0);
		    if (DAT_ram_009d3e38 == 1) break;
		code_r0x80edf2b4:
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_vii(*puVar3,piVar4,puVar3[1]);
		  } while (DAT_ram_009d3e38 != 1);
		  DAT_ram_009d3e38 = 0;
		  param1_00 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x80edf311:
		  iVar5 = global_1;
		  iVar2 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		  if (iVar5 == iVar2) {
		    piVar4 = (int *)import::env::__cxa_begin_catch(param1_00);
		    iVar2 = *piVar4;
		    DAT_ram_009d3e38 = 0;
		    local_18 = iVar2;
		    import::env::invoke_v(0x123);
		    iVar5 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar5 != 1) {
		      if (iVar2 != 0) {
		        System_Data_DataSet__ValidateLocaleConstraint(iVar2);
		        do {
		          halt_trap();
		        } while( true );
		      }
		code_r0x80edf367:
		      DAT_ram_009d3e38 = 0;
		      MVC_AbstractViewMediator_object__object__object__object___Core_MVC_Interfaces_IViewMediator_set_View
		                (param1,
		                 Method_MVC_AbstractViewMediator_TutorialModel__TutorialEvents__TutorialController__TutorialView__Dispose__
		                );
		      return;
		    }
		    param1_00 = import::env::__cxa_find_matching_catch_2();
		  }
		  DAT_ram_009d3e38 = 0;
		  import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_00001b87 + 0x15b,&local_18);
		  iVar5 = DAT_ram_009d3e38;
		  DAT_ram_009d3e38 = 0;
		  if (iVar5 == 1) {
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
	}
}
