using System;
using Il2CppDummyDll;

namespace Core.Errors.Expected
{
	// Token: 0x02001054 RID: 4180
	[Token(Token = "0x2001054")]
	public class ExpectedDefaultError
	{
		// Token: 0x0600622F RID: 25135 RVA: 0x00012498 File Offset: 0x00010698
		[Token(Token = "0x600622F")]
		[Address(RVA = "0xAE5A", Offset = "0xAE5A", VA = "0xAE5A", Slot = "4")]
		public virtual bool Handle(int errorCode)
		{
			return default(bool);
		}

		// Token: 0x06006230 RID: 25136 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006230")]
		[Address(RVA = "0xAE5B", Offset = "0xAE5B", VA = "0xAE5B")]
		public ExpectedDefaultError()
		{
		/* --- GHIDRA: .ctor ---
		undefined4
		Core_Errors_Expected_ExpectedDefaultError___ctor
		          (int param1,int param2,undefined4 param3,undefined4 param4)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  int *piVar3;
		  undefined4 *puVar4;
		  int iVar5;
		  int iVar6;
		  undefined4 param1_00;
		  int local_4;
		  
		  uVar1 = 0;
		  if (DAT_ram_00a5a372 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_Type__object__TryGetValue__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Linq_Enumerable_ToDictionary_KeyValuePair_Type__object___Type__object___
		              );
		    Mono_Security_ASN1__get_Item(&Core_Errors_Expected_ExpectedDefaultError_TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Func_KeyValuePair_Type__object___Type__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Func_KeyValuePair_Type__object___object__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Errors_Expected_ExpectedErrorsHandler___c__InternalHandler_b__0_0__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Errors_Expected_ExpectedErrorsHandler___c__InternalHandler_b__0_1__);
		    Mono_Security_ASN1__get_Item(&Core_Errors_Expected_ExpectedErrorsHandler___c_TypeInfo);
		    DAT_ram_00a5a372 = '\x01';
		  }
		  local_4 = 0;
		  if (param1 < 0) {
		    if (*(int *)(Core_Errors_Expected_ExpectedErrorsHandler___c_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_Errors_Expected_ExpectedErrorsHandler___c_TypeInfo);
		    }
		    puVar4 = *(undefined4 **)(Core_Errors_Expected_ExpectedErrorsHandler___c_TypeInfo + 0x5c);
		    iVar5 = puVar4[1];
		    iVar2 = Core_Errors_Expected_ExpectedErrorsHandler___c_TypeInfo;
		    if (iVar5 == 0) {
		      if (*(int *)(Core_Errors_Expected_ExpectedErrorsHandler___c_TypeInfo + 0x74) == 0) {
		        func_ii_306000(Core_Errors_Expected_ExpectedErrorsHandler___c_TypeInfo);
		        puVar4 = *(undefined4 **)(Core_Errors_Expected_ExpectedErrorsHandler___c_TypeInfo + 0x5c);
		      }
		      uVar1 = *puVar4;
		      iVar5 = unnamed_function_1417(System_Func_KeyValuePair_Type__object___Type__TypeInfo);
		      func_ii_7795(iVar5,uVar1,
		                   Method_Core_Errors_Expected_ExpectedErrorsHandler___c__InternalHandler_b__0_0__,0
		                  );
		      iVar2 = Core_Errors_Expected_ExpectedErrorsHandler___c_TypeInfo;
		      *(int *)(*(int *)(Core_Errors_Expected_ExpectedErrorsHandler___c_TypeInfo + 0x5c) + 4) = iVar5
		      ;
		    }
		    if (*(int *)(iVar2 + 0x74) == 0) {
		      func_ii_306000(iVar2);
		      iVar2 = Core_Errors_Expected_ExpectedErrorsHandler___c_TypeInfo;
		    }
		    puVar4 = *(undefined4 **)(iVar2 + 0x5c);
		    iVar6 = puVar4[2];
		    if (iVar6 == 0) {
		      if (*(int *)(iVar2 + 0x74) == 0) {
		        func_ii_306000(iVar2);
		        puVar4 = *(undefined4 **)(Core_Errors_Expected_ExpectedErrorsHandler___c_TypeInfo + 0x5c);
		      }
		      uVar1 = *puVar4;
		      iVar6 = unnamed_function_1417(System_Func_KeyValuePair_Type__object___object__TypeInfo);
		      func_ii_7795(iVar6,uVar1,
		                   Method_Core_Errors_Expected_ExpectedErrorsHandler___c__InternalHandler_b__0_1__,0
		                  );
		      *(int *)(*(int *)(Core_Errors_Expected_ExpectedErrorsHandler___c_TypeInfo + 0x5c) + 8) = iVar6
		      ;
		    }
		    iVar2 = 0;
		    uVar1 = System_Func_KeyValuePair_object__object___object____ctor
		                      (param3,iVar5,iVar6,
		                       Method_System_Linq_Enumerable_ToDictionary_KeyValuePair_Type__object___Type__object___
		                      );
		    iVar5 = *(int *)(param2 + 0xc);
		    if (0 < iVar5) {
		      do {
		        param1_00 = *(undefined4 *)(param2 + iVar2 * 4 + 0x10);
		        piVar3 = (int *)func_ii_2006(param1_00,0);
		        if (piVar3 != (int *)0x0) {
		          if (((uint)*(byte *)(*piVar3 + 0xb8) <
		               (uint)*(byte *)(Core_Errors_Expected_ExpectedDefaultError_TypeInfo + 0xb8)) ||
		             (*(int *)(*(int *)(*piVar3 + 100) +
		                       (uint)*(byte *)(Core_Errors_Expected_ExpectedDefaultError_TypeInfo + 0xb8) *
		                       4 + -4) != Core_Errors_Expected_ExpectedDefaultError_TypeInfo)) {
		            System_Activator__CreateInstance
		                      (piVar3,Core_Errors_Expected_ExpectedDefaultError_TypeInfo);
		            do {
		              halt_trap();
		            } while( true );
		          }
		        }
		        iVar6 = Spine_Unity_AttachmentTools_AttachmentRegionExtensions__GetRegion
		                          (uVar1,param1_00,&local_4,
		                           Method_System_Collections_Generic_Dictionary_Type__object__TryGetValue__)
		        ;
		        if ((iVar6 != 0) && (local_4 != 0)) {
		          piVar3[2] = local_4;
		        }
		        iVar6 = (**(code **)((ulonglong)*(uint *)(*piVar3 + 0xe0) * 4))
		                          (piVar3,param1,*(undefined4 *)(*piVar3 + 0xe4));
		        if (iVar6 != 0) {
		          return 1;
		        }
		        iVar2 = iVar2 + 1;
		      } while (iVar2 != iVar5);
		    }
		    piVar3 = (int *)unnamed_function_1417(Core_Errors_Expected_ExpectedDefaultError_TypeInfo);
		    uVar1 = (**(code **)((ulonglong)*(uint *)(*piVar3 + 0xe0) * 4))
		                      (piVar3,param1,*(undefined4 *)(*piVar3 + 0xe4));
		  }
		  return uVar1;
		}
		*/

		}

		// Token: 0x040034DA RID: 13530
		[Token(Token = "0x40034DA")]
		[FieldOffset(Offset = "0x8")]
		public object Args;
	}
}
