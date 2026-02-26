using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace Core.Errors.Expected
{
	// Token: 0x0200104F RID: 4175
	[Token(Token = "0x200104F")]
	public class ExpectedCraftErrors : ExpectedDefaultError
	{
		// Token: 0x06006220 RID: 25120 RVA: 0x00012450 File Offset: 0x00010650
		[Token(Token = "0x6006220")]
		[Address(RVA = "0xAE4B", Offset = "0xAE4B", VA = "0xAE4B", Slot = "4")]
		public override bool Handle(int errorCode)
		{
		/* --- GHIDRA: Handle ---
		void Core_Errors_Expected_ExpectedCraftErrors__Handle
		               (undefined4 param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  
		  uVar1 = System_Uri___ctor(0);
		  uVar1 = System_Globalization_TimeSpanFormat_FormatLiterals__get_DayHourSep(uVar1,0);
		  Core_Application_App__get_ToastController(uVar1,2,param2,0);
		  return;
		}
		*/

			return default(bool);
		}

		// Token: 0x06006221 RID: 25121 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006221")]
		[Address(RVA = "0xAE4C", Offset = "0xAE4C", VA = "0xAE4C")]
		public void ShowToast(string msg)
		{
		}

		// Token: 0x06006222 RID: 25122 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006222")]
		[Address(RVA = "0xAE4D", Offset = "0xAE4D", VA = "0xAE4D")]
		public ExpectedCraftErrors()
		{
		/* --- GHIDRA: .ctor ---
		void Core_Errors_Expected_ExpectedCraftErrors___ctor(int param1,int param2,undefined4 param3)
		
		{
		  uint uVar1;
		  undefined4 param1_00;
		  int *piVar2;
		  uint *puVar3;
		  int iVar4;
		  int iVar5;
		  int local_c;
		  int **local_8;
		  int *local_4;
		  
		  iVar5 = 0;
		  if (DAT_ram_00a5a36c == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Core_Errors_Expected_ExpectedCraftErrors_ExpectedCraftErrorsArgs_TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_IDisposable_TypeInfo);
		    DAT_ram_00a5a36c = '\x01';
		  }
		  if (*(int *)(param2 + 8) == 2) {
		    local_4 = *(int **)(param1 + 8);
		    if (local_4 != (int *)0x0) {
		      if (((uint)*(byte *)(*local_4 + 0xb8) <
		           (uint)*(byte *)(Core_Errors_Expected_ExpectedCraftErrors_ExpectedCraftErrorsArgs_TypeInfo
		                          + 0xb8)) ||
		         (*(int *)(*(int *)(*local_4 + 100) +
		                   (uint)*(byte *)(
		                                  Core_Errors_Expected_ExpectedCraftErrors_ExpectedCraftErrorsArgs_TypeInfo
		                                  + 0xb8) * 4 + -4) !=
		          Core_Errors_Expected_ExpectedCraftErrors_ExpectedCraftErrorsArgs_TypeInfo)) {
		        System_Activator__CreateInstance
		                  (local_4,Core_Errors_Expected_ExpectedCraftErrors_ExpectedCraftErrorsArgs_TypeInfo
		                  );
		        do {
		          halt_trap();
		        } while( true );
		      }
		    }
		    local_c = 0;
		    local_8 = &local_4;
		    iVar4 = local_4[2];
		    if (iVar4 != 0) {
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_vii
		                (*(undefined4 *)(iVar4 + 0xc),*(undefined4 *)(iVar4 + 0x20),
		                 *(undefined4 *)(iVar4 + 0x14));
		      iVar4 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar4 == 1) {
		        param1_00 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        iVar5 = global_1;
		        iVar4 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		        if (iVar5 != iVar4) {
		code_r0x8120d174:
		          DAT_ram_009d3e38 = 0;
		          import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_00001f04 + 0x2ad,&local_c);
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
		        piVar2 = (int *)import::env::__cxa_begin_catch(param1_00);
		        iVar5 = *piVar2;
		        DAT_ram_009d3e38 = 0;
		        local_c = iVar5;
		        import::env::invoke_v(0x123);
		        iVar4 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar4 == 1) {
		          param1_00 = import::env::__cxa_find_matching_catch_2();
		          goto code_r0x8120d174;
		        }
		      }
		    }
		    piVar2 = local_4;
		    if (local_4 != (int *)0x0) {
		      uVar1 = 0;
		      iVar4 = *local_4;
		      if (*(ushort *)(iVar4 + 0xb6) != 0) {
		        do {
		          if (System_IDisposable_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		            puVar3 = (uint *)(iVar4 + *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		            goto code_r0x8120d153;
		          }
		          uVar1 = uVar1 + 1;
		        } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		      }
		      puVar3 = (uint *)func_ii_1080(local_4,System_IDisposable_TypeInfo,0);
		code_r0x8120d153:
		      (**(code **)((ulonglong)*puVar3 * 4))(piVar2,puVar3[1]);
		    }
		    if (iVar5 != 0) {
		      System_Data_DataSet__ValidateLocaleConstraint(iVar5);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  return;
		}
		*/

		}

		// Token: 0x02001050 RID: 4176
		[Token(Token = "0x2001050")]
		public class ExpectedCraftErrorsArgs : IDisposable
		{
			// Token: 0x170013A6 RID: 5030
			// (get) Token: 0x06006224 RID: 25124 RVA: 0x00002052 File Offset: 0x00000252
			// (set) Token: 0x06006225 RID: 25125 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170013A6")]
			public Action Callback
			{
				[Token(Token = "0x6006224")]
				[Address(RVA = "0xAE4F", Offset = "0xAE4F", VA = "0xAE4F")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x6006225")]
				[Address(RVA = "0xAE50", Offset = "0xAE50", VA = "0xAE50")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x06006226 RID: 25126 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6006226")]
			[Address(RVA = "0xAE51", Offset = "0xAE51", VA = "0xAE51")]
			public ExpectedCraftErrorsArgs(Action callback)
			{
			}

			// Token: 0x06006227 RID: 25127 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6006227")]
			[Address(RVA = "0xAE52", Offset = "0xAE52", VA = "0xAE52", Slot = "4")]
			public void Dispose()
			{
			}
		}
	}
}
