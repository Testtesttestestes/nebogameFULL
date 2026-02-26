using System;
using Core.Data.Skills;
using Il2CppDummyDll;

namespace Core.Data.Effect
{
	// Token: 0x020010EC RID: 4332
	[Token(Token = "0x20010EC")]
	public class EffectDescription : AbstractEffectDescription
	{
		// Token: 0x06006548 RID: 25928 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006548")]
		[Address(RVA = "0xB114", Offset = "0xB114", VA = "0xB114")]
		public EffectDescription(string sourceText, EffectData[] effects, Skills userSkills)
		{
		/* --- GHIDRA: .ctor ---
		undefined4
		Core_Data_Effect_EffectDescription___ctor
		          (undefined4 param1,undefined8 param2,ulonglong param3,undefined4 param4)
		
		{
		  undefined4 uVar1;
		  undefined4 *puVar2;
		  undefined8 local_8;
		  
		  local_8 = param2;
		  if (DAT_ram_00a60844 == '\0') {
		    Mono_Security_ASN1__get_Item(&StringLiteral_708);
		    Mono_Security_ASN1__get_Item(&StringLiteral_5);
		    DAT_ram_00a60844 = '\x01';
		  }
		  uVar1 = UnityEngine_GameObject__SetActive(&local_8,0);
		  puVar2 = &StringLiteral_5;
		  if ((param3 & 0x80000000) != 0) {
		    puVar2 = &StringLiteral_708;
		  }
		  uVar1 = Mono_Security_X509_X509Crl_X509CrlEntry___ctor(uVar1,*puVar2,0);
		  return uVar1;
		}
		*/

		}

		// Token: 0x06006549 RID: 25929 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6006549")]
		[Address(RVA = "0xB115", Offset = "0xB115", VA = "0xB115", Slot = "7")]
		protected override string FormatUserSkillValue(long validValue, long rawValue)
		{
		/* --- GHIDRA: FormatUserSkillValue ---
		void Core_Data_Effect_EffectDescription__FormatUserSkillValue
		               (int param1,int param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  undefined4 *puVar2;
		  int param1_00;
		  undefined4 param2_00;
		  
		  if (DAT_ram_00a60845 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_Select_uint__long___);
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_ToList_long___);
		    Mono_Security_ASN1__get_Item(&System_Func_uint__long__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Data_Decorators_RewardInfoDecorator___c___ctor_b__1_0__);
		    Mono_Security_ASN1__get_Item(&Core_Data_Decorators_RewardInfoDecorator___c_TypeInfo);
		    DAT_ram_00a60845 = '\x01';
		  }
		  *(int *)(param1 + 8) = param2;
		  uVar1 = *(undefined4 *)(param2 + 0x10);
		  if (*(int *)(Core_Data_Decorators_RewardInfoDecorator___c_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_Data_Decorators_RewardInfoDecorator___c_TypeInfo);
		  }
		  puVar2 = *(undefined4 **)(Core_Data_Decorators_RewardInfoDecorator___c_TypeInfo + 0x5c);
		  param1_00 = puVar2[1];
		  if (param1_00 == 0) {
		    if (*(int *)(Core_Data_Decorators_RewardInfoDecorator___c_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_Data_Decorators_RewardInfoDecorator___c_TypeInfo);
		      puVar2 = *(undefined4 **)(Core_Data_Decorators_RewardInfoDecorator___c_TypeInfo + 0x5c);
		    }
		    param2_00 = *puVar2;
		    param1_00 = unnamed_function_1417(System_Func_uint__long__TypeInfo);
		    System_Func_uint__Int32Enum___Invoke
		              (param1_00,param2_00,
		               Method_Core_Data_Decorators_RewardInfoDecorator___c___ctor_b__1_0__,0);
		    *(int *)(*(int *)(Core_Data_Decorators_RewardInfoDecorator___c_TypeInfo + 0x5c) + 4) = param1_00
		    ;
		  }
		  uVar1 = System_Linq_Enumerable__Select_uint__Int32Enum_
		                    (uVar1,param1_00,Method_System_Linq_Enumerable_Select_uint__long___);
		  uVar1 = System_Linq_Enumerable__ToList_int_(uVar1,Method_System_Linq_Enumerable_ToList_long___);
		  *(undefined4 *)(param1 + 0xc) = uVar1;
		  return;
		}
		*/

			return null;
		}
	}
}
