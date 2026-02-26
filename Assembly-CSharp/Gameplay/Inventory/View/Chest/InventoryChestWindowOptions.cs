using System;
using Core.Data;
using Il2CppDummyDll;
using Protocol.Dic;
using UI.Windows;

namespace Gameplay.Inventory.View.Chest
{
	// Token: 0x02000685 RID: 1669
	[Token(Token = "0x2000685")]
	public class InventoryChestWindowOptions : BaseWindowArgs
	{
		// Token: 0x06002866 RID: 10342 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002866")]
		[Address(RVA = "0x7986", Offset = "0x7986", VA = "0x7986")]
		public InventoryChestWindowOptions()
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_Inventory_View_Chest_InventoryChestWindowOptions___ctor
		               (int param1,int param2,int param3,undefined4 param4)
		
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
		    if (cVar1 == '\0') {
		      if (*(char *)(param1 + 0x38) == '\0') {
		        *(char **)(param1 + 0xc) = s_struct_Uniforms___color__array<v_ram_00001f04 + 600;
		      }
		      else {
		        iVar2 = unnamed_function_159288(param3);
		        iVar3 = func_ii_21171(param3);
		        if (iVar2 == 0) {
		          if (iVar3 == 0) {
		            *(char **)(param1 + 0xc) = s_struct_Uniforms___color__array<v_ram_00001f04 + 599;
		          }
		          else {
		            *(char **)(param1 + 0xc) = s_struct_Uniforms___color__array<v_ram_00001f04 + 0x256;
		          }
		        }
		        else if (iVar3 == 0) {
		          *(char **)(param1 + 0xc) = s_struct_Uniforms___color__array<v_ram_00001f04 + 0x255;
		        }
		        else {
		          *(char **)(param1 + 0xc) = s_struct_Uniforms___color__array<v_ram_00001f04 + 0x254;
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
		  else if (cVar1 == '\x01') {
		    *(char **)(param1 + 0xc) = s_struct_Uniforms___color__array<v_ram_00001f04 + 0x253;
		  }
		  else {
		    *(undefined4 *)(param1 + 0xc) = *(undefined4 *)(param1 + 8);
		    *(undefined4 *)(param1 + 0x20) = *(undefined4 *)(param1 + 0x10);
		  }
		  *(char **)(param1 + 0x1c) = s_struct_Uniforms___color__array<v_ram_00001f04 + 0x259;
		  return;
		}
		*/

		}

		// Token: 0x04001648 RID: 5704
		[Token(Token = "0x4001648")]
		[FieldOffset(Offset = "0x18")]
		public ArtikulMenuActionDic.Types.Actions[] CustomActions;

		// Token: 0x04001649 RID: 5705
		[Token(Token = "0x4001649")]
		[FieldOffset(Offset = "0x1C")]
		public ArtikulMenuActionDic.Types.Actions[] CloseWindowActions;

		// Token: 0x0400164A RID: 5706
		[Token(Token = "0x400164A")]
		[FieldOffset(Offset = "0x20")]
		public InventoryChestWindowOptions.ArtifactFilterDelegate CustomFilterFunction;

		// Token: 0x02000686 RID: 1670
		// (Invoke) Token: 0x06002868 RID: 10344
		[Token(Token = "0x2000686")]
		public delegate bool ArtifactFilterDelegate(ArtifactData artifactData);
	}
}
