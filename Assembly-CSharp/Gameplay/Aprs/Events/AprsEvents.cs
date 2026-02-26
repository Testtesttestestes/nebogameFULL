using System;
using Gameplay.Aprs.Model;
using Il2CppDummyDll;
using MVC;

namespace Gameplay.Aprs.Events
{
	// Token: 0x02000D69 RID: 3433
	[Token(Token = "0x2000D69")]
	public class AprsEvents : AbstractMVCEvents
	{
		// Token: 0x0600542C RID: 21548 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600542C")]
		[Address(RVA = "0xA1E3", Offset = "0xA1E3", VA = "0xA1E3")]
		public AprsEvents()
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_Aprs_Events_AprsEvents___ctor(int param1,int param2,int param3,undefined4 param4)
		
		{
		  char cVar1;
		  int iVar2;
		  int iVar3;
		  undefined4 uVar4;
		  
		  uVar4 = *(undefined4 *)(param3 + 4);
		  *(int *)(param1 + 0x14) = param3;
		  *(undefined4 *)(param1 + 8) = uVar4;
		  *(int *)(param1 + 0x10) = param2;
		  cVar1 = *(char *)(param3 + 0x2e);
		  *(int *)(param1 + 0x20) = param1;
		  iVar2 = func_ii_4538(param3);
		  if (iVar2 == 0) {
		    if (cVar1 == '\x01') {
		      if (*(char *)(param1 + 0x38) == '\0') {
		        *(char **)(param1 + 0xc) = s_struct_Uniforms___color__array<v_ram_00001b87 + 0x2c4;
		      }
		      else {
		        iVar2 = unnamed_function_159288(param3);
		        iVar3 = func_ii_21171(param3);
		        if (iVar2 == 0) {
		          if (iVar3 == 0) {
		            *(char **)(param1 + 0xc) = s_struct_Uniforms___color__array<v_ram_00001b87 + 0x2c3;
		          }
		          else {
		            *(char **)(param1 + 0xc) = s_struct_Uniforms___color__array<v_ram_00001b87 + 0x2c2;
		          }
		        }
		        else if (iVar3 == 0) {
		          *(char **)(param1 + 0xc) = s_struct_Uniforms___color__array<v_ram_00001b87 + 0x2c1;
		        }
		        else {
		          *(char **)(param1 + 0xc) = s_struct_Uniforms___color__array<v_ram_00001b87 + 0x2c0;
		        }
		      }
		    }
		    else {
		      if (param2 == 0) {
		        uVar4 = Mono_Unity_CertHelper__AddCertificatesToNativeChain
		                          (0,s_Delegate_to_an_instance_method_c_ram_0005d205);
		        func_ii_1050(uVar4,0);
		        do {
		          halt_trap();
		        } while( true );
		      }
		      *(undefined4 *)(param1 + 0xc) = *(undefined4 *)(param1 + 8);
		      *(undefined4 *)(param1 + 0x20) = *(undefined4 *)(param1 + 0x10);
		    }
		  }
		  else if (cVar1 == '\x02') {
		    *(char **)(param1 + 0xc) = s_struct_Uniforms___color__array<v_ram_00001b87 + 0x2bf;
		  }
		  else {
		    *(undefined4 *)(param1 + 0xc) = *(undefined4 *)(param1 + 8);
		    *(undefined4 *)(param1 + 0x20) = *(undefined4 *)(param1 + 0x10);
		  }
		  *(char **)(param1 + 0x1c) = s_struct_Uniforms___color__array<v_ram_00001b87 + 0x2c5;
		  return;
		}
		*/

		}

		// Token: 0x04002D98 RID: 11672
		[Token(Token = "0x4002D98")]
		[FieldOffset(Offset = "0x14")]
		public AprsEvents.AprChangedEventDelegate AprChangedEvent;

		// Token: 0x04002D99 RID: 11673
		[Token(Token = "0x4002D99")]
		[FieldOffset(Offset = "0x18")]
		public Action OwnerChangedEvent;

		// Token: 0x04002D9A RID: 11674
		[Token(Token = "0x4002D9A")]
		[FieldOffset(Offset = "0x1C")]
		public Action DictProviderChanged;

		// Token: 0x02000D6A RID: 3434
		// (Invoke) Token: 0x0600542E RID: 21550
		[Token(Token = "0x2000D6A")]
		public delegate void AprChangedEventDelegate(AprData aprData, uint medalId);
	}
}
