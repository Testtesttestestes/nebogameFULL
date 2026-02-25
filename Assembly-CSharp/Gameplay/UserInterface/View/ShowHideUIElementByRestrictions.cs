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
