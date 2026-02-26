using System;
using Core.Data;
using Il2CppDummyDll;
using MVC;
using Protocol.Main;

namespace Gameplay.Medals.Events
{
	// Token: 0x02000608 RID: 1544
	[Token(Token = "0x2000608")]
	public class MedalsEvents : AbstractMVCEvents
	{
		// Token: 0x06002577 RID: 9591 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002577")]
		[Address(RVA = "0x76BC", Offset = "0x76BC", VA = "0x76BC")]
		public MedalsEvents()
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_Medals_Events_MedalsEvents___ctor(int param1,int param2,int param3,undefined4 param4)
		
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
		        *(char **)(param1 + 0xc) = s_struct_Uniforms___color__array<v_ram_00001b87 + 0x85;
		      }
		      else {
		        iVar2 = unnamed_function_159288(param3);
		        iVar3 = func_ii_21171(param3);
		        if (iVar2 == 0) {
		          if (iVar3 == 0) {
		            *(char **)(param1 + 0xc) = s_struct_Uniforms___color__array<v_ram_00001b87 + 0x84;
		          }
		          else {
		            *(char **)(param1 + 0xc) = s_struct_Uniforms___color__array<v_ram_00001b87 + 0x83;
		          }
		        }
		        else if (iVar3 == 0) {
		          *(char **)(param1 + 0xc) = s_struct_Uniforms___color__array<v_ram_00001b87 + 0x82;
		        }
		        else {
		          *(char **)(param1 + 0xc) = s_struct_Uniforms___color__array<v_ram_00001b87 + 0x81;
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
		    *(char **)(param1 + 0xc) = s_struct_Uniforms___color__array<v_ram_00001b87 + 0x80;
		  }
		  else {
		    *(undefined4 *)(param1 + 0xc) = *(undefined4 *)(param1 + 8);
		    *(undefined4 *)(param1 + 0x20) = *(undefined4 *)(param1 + 0x10);
		  }
		  *(char **)(param1 + 0x1c) = s_struct_Uniforms___color__array<v_ram_00001b87 + 0x86;
		  return;
		}
		*/

		}

		// Token: 0x04001482 RID: 5250
		[Token(Token = "0x4001482")]
		[FieldOffset(Offset = "0x14")]
		public MedalsEvents.MedalChangedEventDelegate MedalChangedEvent;

		// Token: 0x04001483 RID: 5251
		[Token(Token = "0x4001483")]
		[FieldOffset(Offset = "0x18")]
		public Action<uint> MedalRemovedEvent;

		// Token: 0x04001484 RID: 5252
		[Token(Token = "0x4001484")]
		[FieldOffset(Offset = "0x1C")]
		public Action<MedalInfo> MedalAddedEvent;

		// Token: 0x04001485 RID: 5253
		[Token(Token = "0x4001485")]
		[FieldOffset(Offset = "0x20")]
		public Action<MedalInfo> MedalBuyEvent;

		// Token: 0x02000609 RID: 1545
		// (Invoke) Token: 0x06002579 RID: 9593
		[Token(Token = "0x2000609")]
		public delegate void MedalChangedEventDelegate(MedalData medalData, uint medalId);
	}
}
