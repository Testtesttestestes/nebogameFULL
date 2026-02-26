using System;
using Core.Animations;
using Il2CppDummyDll;

namespace Animations
{
	// Token: 0x02001331 RID: 4913
	[Token(Token = "0x2001331")]
	public class MonsterAnimation : GameGafAnimation
	{
		// Token: 0x06007461 RID: 29793 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007461")]
		[Address(RVA = "0xBE2D", Offset = "0xBE2D", VA = "0xBE2D")]
		public MonsterAnimation()
		{
		/* --- GHIDRA: .ctor ---
		void Animations_MonsterAnimation___ctor(undefined4 param1,undefined4 param2)
		
		{
		  int *piVar1;
		  uint uVar2;
		  int iVar3;
		  uint *puVar4;
		  undefined4 uVar5;
		  undefined4 uVar6;
		  int *local_4;
		  
		  if (DAT_ram_00a596ae == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_Component_TryGetComponent_IGameAnimation___);
		    Mono_Security_ASN1__get_Item(&Core_Animations_IGameAnimation_TypeInfo);
		    DAT_ram_00a596ae = '\x01';
		  }
		  local_4 = (int *)0x0;
		  iVar3 = UnityEngine_UIElements_GroupBoxUtility__UnregisterGroupBoxOption_object_
		                    (param1,&local_4,Method_UnityEngine_Component_TryGetComponent_IGameAnimation___)
		  ;
		  piVar1 = local_4;
		  if (iVar3 == 0) {
		    uVar5 = GAFInternal_Assets_GAFAnimationAssetInternal__collectExternalData(param1,0);
		    uVar6 = unnamed_function_2232(&StringLiteral_5645);
		    uVar5 = Mono_Security_X509_X509Crl_X509CrlEntry___ctor(uVar6,uVar5,0);
		    uVar6 = unnamed_function_2232(&System_Exception_TypeInfo);
		    uVar6 = unnamed_function_1417(uVar6);
		    System_String__Concat(uVar6,uVar5,0);
		    uVar5 = unnamed_function_2232(&Method_Animations_PlayOnStart_Start__);
		    func_ii_1050(uVar6,uVar5);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  uVar2 = 0;
		  iVar3 = *local_4;
		  if (*(ushort *)(iVar3 + 0xb6) != 0) {
		    do {
		      if (Core_Animations_IGameAnimation_TypeInfo == *(int *)(*(int *)(iVar3 + 0x58) + uVar2 * 8)) {
		        puVar4 = (uint *)(*(int *)(*(int *)(iVar3 + 0x58) + uVar2 * 8 + 4) * 8 + iVar3 + 0x120);
		        goto code_r0x8104cd8c;
		      }
		      uVar2 = uVar2 + 1;
		    } while (*(ushort *)(iVar3 + 0xb6) != uVar2);
		  }
		  puVar4 = (uint *)func_ii_1080(local_4,Core_Animations_IGameAnimation_TypeInfo,0xc);
		code_r0x8104cd8c:
		  (**(code **)((ulonglong)*puVar4 * 4))(piVar1,1,puVar4[1]);
		  return;
		}
		*/

		}
	}
}
