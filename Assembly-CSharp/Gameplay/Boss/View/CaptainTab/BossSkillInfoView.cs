using System;
using Gameplay.UserInfo.View;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;

namespace Gameplay.Boss.View.CaptainTab
{
	// Token: 0x02000B7E RID: 2942
	[Token(Token = "0x2000B7E")]
	public class BossSkillInfoView : SkillsInfoView
	{
		// Token: 0x17000E49 RID: 3657
		// (set) Token: 0x06004773 RID: 18291 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000E49")]
		public string Description
		{
			[Token(Token = "0x6004773")]
			[Address(RVA = "0x1B57", Offset = "0x1B57", VA = "0x1B57")]
			set
			{
			}
		}

		// Token: 0x17000E4A RID: 3658
		// (set) Token: 0x06004774 RID: 18292 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000E4A")]
		public string DominateCultDescription
		{
			[Token(Token = "0x6004774")]
			[Address(RVA = "0x1B5C", Offset = "0x1B5C", VA = "0x1B5C")]
			set
			{
			}
		}

		// Token: 0x06004775 RID: 18293 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004775")]
		[Address(RVA = "0x9605", Offset = "0x9605", VA = "0x9605")]
		public BossSkillInfoView()
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_Boss_View_CaptainTab_BossSkillInfoView___ctor
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a57a4a == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TeamData_TeamAssistantData__TypeInfo);
		    DAT_ram_00a57a4a = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x30);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = UnityEngine_UI_Image__set_sprite(param1_00,param2,0);
		    param2_00 = System_Action_TeamData_TeamAssistantData__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_TeamData_TeamAssistantData__TypeInfo),
		       iVar2 == 0)) break;
		    iVar2 = func_ii_4329(param1 + 0x30,iVar2,param1_00);
		    bVar1 = iVar2 == param1_00;
		    param1_00 = iVar2;
		    if (bVar1) {
		      return;
		    }
		  }
		  System_Activator__CreateInstance(param1_01,param2_00);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}

		// Token: 0x0400273E RID: 10046
		[Token(Token = "0x400273E")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		private TextMeshProUGUI _descLabel;

		// Token: 0x0400273F RID: 10047
		[Token(Token = "0x400273F")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private TextMeshProUGUI _dominateCultLabel;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: set_DominateCultDescription ---
		undefined4
		Gameplay_Boss_View_CaptainTab_BossSkillInfoView__set_DominateCultDescription
		          (int param1,undefined4 param2)
		
		{
		  int param2_00;
		  int iVar1;
		  int param1_00;
		  undefined4 uVar2;
		  
		  param1_00 = *(int *)(param1 + 0x18);
		  param2_00 = 0;
		  if (DAT_ram_00a5acf4 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_ContentResourceAsset__get_Count__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_ContentResourceAsset__get_Item__);
		    DAT_ram_00a5acf4 = '\x01';
		  }
		  if (*(int *)(param1_00 + 0xc) < 1) {
		    uVar2 = 0;
		  }
		  else {
		    while (iVar1 = Google_Protobuf_Collections_RepeatedField_Int32Enum___get_IsReadOnly
		                             (param1_00,param2_00,
		                              Method_Google_Protobuf_Collections_RepeatedField_ContentResourceAsset__get_Item__
		                             ), *(int *)(iVar1 + 0xc) != 0x29) {
		      param2_00 = param2_00 + 1;
		      if (*(int *)(param1_00 + 0xc) <= param2_00) {
		        return 0;
		      }
		    }
		    uVar2 = *(undefined4 *)(iVar1 + 0x10);
		  }
		  return uVar2;
		}
		*/

}
