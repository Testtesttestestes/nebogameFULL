using System;
using Il2CppDummyDll;
using MVC;

namespace Gameplay.UserInterface.Menu.Settings
{
	// Token: 0x020003D8 RID: 984
	[Token(Token = "0x20003D8")]
	public class SettingsEvents : AbstractMVCEvents
	{
		// Token: 0x06001717 RID: 5911 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001717")]
		[Address(RVA = "0x68D6", Offset = "0x68D6", VA = "0x68D6")]
		public SettingsEvents()
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_UserInterface_Menu_Settings_SettingsEvents___ctor
		               (int param1,int param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  undefined4 uVar2;
		  undefined4 *puVar3;
		  int local_4;
		  
		  if (param2 == 0x1e) {
		    puVar3 = (undefined4 *)(param1 + 0x18);
		  }
		  else {
		    if (((((param2 == 0x1f) || (param2 == 0x20)) || (param2 == 0x21)) ||
		        ((((param2 == 0x22 || (param2 == 0x23)) ||
		          ((param2 == 0x24 || ((param2 == 0x25 || (param2 == 0x26)))))) || (param2 == 0x27)))) ||
		       (((param2 == 0x28 || (param2 == 0x29)) || (param2 == 0x2a)))) {
		code_r0x8107e7c5:
		      local_4 = param2;
		      uVar1 = unnamed_function_2232(&UnityEngine_SystemLanguage_TypeInfo);
		      uVar1 = func_ii_1081(uVar1,&local_4);
		      uVar2 = unnamed_function_2232(&StringLiteral_15764);
		      uVar1 = func_ii_4419(uVar2,uVar1,0);
		      uVar2 = unnamed_function_2232(&System_NotSupportedException_TypeInfo);
		      uVar2 = unnamed_function_1417(uVar2);
		      System_Xml_Serialization_XmlReflectionImporter__ImportXmlSerializableMapping(uVar2,uVar1,0);
		      uVar1 = unnamed_function_2232
		                        (&
		                         Method_Gameplay_UserInterface_Menu_Settings_View_LanguageSectionView_set_Language__
		                        );
		      func_ii_1050(uVar2,uVar1);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    if (param2 == 0x2b) {
		      puVar3 = (undefined4 *)(param1 + 0x10);
		    }
		    else {
		      if (param2 != 10) goto code_r0x8107e7c5;
		      puVar3 = (undefined4 *)(param1 + 0x14);
		    }
		  }
		  UnityEngine_UI_Toggle__get_isOn(*puVar3,1,0);
		  *(int *)(param1 + 0x20) = param2;
		  return;
		}
		*/

		}
	}
}
