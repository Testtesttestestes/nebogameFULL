using System;
using Core.Data;
using Core.Dict;
using Core.Gameplay.Managers.Requirements;
using Il2CppDummyDll;
using UnityEngine;

namespace Gameplay.UserInterface.View
{
	// Token: 0x020003C1 RID: 961
	[Token(Token = "0x20003C1")]
	public class ShowHideUIElementByRestrictions : MonoBehaviour
	{
		// Token: 0x06001680 RID: 5760 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001680")]
		[Address(RVA = "0x6841", Offset = "0x6841", VA = "0x6841")]
		public void Validate(UserData user, IRequirementValidator requirementValidator, IDictProvider dictProvider)
		{
		}

		// Token: 0x06001681 RID: 5761 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001681")]
		[Address(RVA = "0x6842", Offset = "0x6842", VA = "0x6842")]
		public ShowHideUIElementByRestrictions()
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_UserInterface_View_ShowHideUIElementByRestrictions___ctor
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4,undefined4 param5)
		
		{
		  int param5_00;
		  int iVar1;
		  int iVar2;
		  int param1_00;
		  
		  iVar1 = *(int *)(param1 + 8);
		  iVar2 = *(int *)(iVar1 + 0xc);
		  if (0 < iVar2) {
		    param5_00 = 0;
		    do {
		      param1_00 = *(int *)(iVar1 + param5_00 * 4 + 0x10);
		      if (param1_00 != 0) {
		        Gameplay_UserInterface_View_RankView_RankImages___ctor
		                  (param1_00,param2,param3,param4,param5_00);
		        iVar2 = *(int *)(iVar1 + 0xc);
		      }
		      param5_00 = param5_00 + 1;
		    } while (param5_00 < iVar2);
		  }
		  return;
		}
		*/

		}

		// Token: 0x04000BD6 RID: 3030
		[Token(Token = "0x4000BD6")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private uint _uiElementId;

		// Token: 0x020003C2 RID: 962
		[Token(Token = "0x20003C2")]
		[Serializable]
		public class UIElementsByRestrictions
		{
			// Token: 0x06001682 RID: 5762 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001682")]
			[Address(RVA = "0x6843", Offset = "0x6843", VA = "0x6843")]
			public void Validate(UserData user, IRequirementValidator requirementValidator, IDictProvider dictProvider)
			{
			}

			// Token: 0x06001683 RID: 5763 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001683")]
			[Address(RVA = "0x6844", Offset = "0x6844", VA = "0x6844")]
			public UIElementsByRestrictions()
			{
			}

			// Token: 0x04000BD7 RID: 3031
			[Token(Token = "0x4000BD7")]
			[FieldOffset(Offset = "0x8")]
			[SerializeField]
			private ShowHideUIElementByRestrictions[] _uiElements;
		}
	}
}
