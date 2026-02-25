using System;
using System.Runtime.CompilerServices;
using Core.Data;
using Core.Gameplay.Managers.Requirements;
using Gameplay.School.Model;
using Il2CppDummyDll;
using TMPro;
using UI.Elements.Buttons;
using UI.Rewards;
using UnityEngine;
using UnityEngine.UI;

namespace UI.Windows.Buildings.MageSchoolWindow
{
	// Token: 0x020002BF RID: 703
	[Token(Token = "0x20002BF")]
	public class SpellUpgradeInfo : MonoBehaviourWithStates<SpellUpgradeInfo.State>
	{
		// Token: 0x14000105 RID: 261
		// (add) Token: 0x0600108C RID: 4236 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x0600108D RID: 4237 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000105")]
		private event Action Learn
		{
			[Token(Token = "0x600108C")]
			[Address(RVA = "0x6289", Offset = "0x6289", VA = "0x6289")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600108D")]
			[Address(RVA = "0x628A", Offset = "0x628A", VA = "0x628A")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000106 RID: 262
		// (add) Token: 0x0600108E RID: 4238 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x0600108F RID: 4239 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000106")]
		private event Action Accelerate
		{
			[Token(Token = "0x600108E")]
			[Address(RVA = "0x628B", Offset = "0x628B", VA = "0x628B")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600108F")]
			[Address(RVA = "0x628C", Offset = "0x628C", VA = "0x628C")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x06001090 RID: 4240 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001090")]
		[Address(RVA = "0x628D", Offset = "0x628D", VA = "0x628D")]
		private void Start()
		{
		}

		// Token: 0x06001091 RID: 4241 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001091")]
		[Address(RVA = "0x628E", Offset = "0x628E", VA = "0x628E")]
		private void OnDestroy()
		{
		}

		// Token: 0x06001092 RID: 4242 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001092")]
		[Address(RVA = "0x628F", Offset = "0x628F", VA = "0x628F", Slot = "4")]
		protected override void HandleCurrentStateChanged(SpellUpgradeInfo.State fromState, SpellUpgradeInfo.State toState)
		{
		}

		// Token: 0x06001093 RID: 4243 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001093")]
		[Address(RVA = "0x6290", Offset = "0x6290", VA = "0x6290")]
		private void ButtonClickedEventHandler()
		{
		}

		// Token: 0x06001094 RID: 4244 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001094")]
		[Address(RVA = "0x6291", Offset = "0x6291", VA = "0x6291")]
		public void Init(SchoolSpellData spellData, IRequirementValidator validator, UserData user, UserData loggedUser)
		{
		}

		// Token: 0x06001095 RID: 4245 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001095")]
		[Address(RVA = "0x6292", Offset = "0x6292", VA = "0x6292")]
		private void ResolveButtonState(SchoolSpellData spellData, UserData loggedUser)
		{
		}

		// Token: 0x06001096 RID: 4246 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001096")]
		[Address(RVA = "0x6293", Offset = "0x6293", VA = "0x6293")]
		public void BindCallbacks(Action learn, Action accelerate)
		{
		}

		// Token: 0x06001097 RID: 4247 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001097")]
		[Address(RVA = "0x6294", Offset = "0x6294", VA = "0x6294")]
		public void UnbindCallbacks()
		{
		}

		// Token: 0x06001098 RID: 4248 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001098")]
		[Address(RVA = "0x6295", Offset = "0x6295", VA = "0x6295")]
		public SpellUpgradeInfo()
		{
		}

		// Token: 0x04000886 RID: 2182
		[Token(Token = "0x4000886")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private TitleValueRender _upgradeTime;

		// Token: 0x04000887 RID: 2183
		[Token(Token = "0x4000887")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private TitleValueRender _schoolLevel;

		// Token: 0x04000888 RID: 2184
		[Token(Token = "0x4000888")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private SpellButtonWithStates _spellButton;

		// Token: 0x04000889 RID: 2185
		[Token(Token = "0x4000889")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Sprite _isOkImage;

		// Token: 0x0400088A RID: 2186
		[Token(Token = "0x400088A")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private Sprite _isNotOkImage;

		// Token: 0x0400088B RID: 2187
		[Token(Token = "0x400088B")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Image _icon;

		// Token: 0x0400088C RID: 2188
		[Token(Token = "0x400088C")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		private TextMeshProUGUI _title;

		// Token: 0x0400088D RID: 2189
		[Token(Token = "0x400088D")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private BacktimeViewUGUIFill _backtimeView;

		// Token: 0x020002C0 RID: 704
		[Token(Token = "0x20002C0")]
		public enum State
		{
			// Token: 0x04000891 RID: 2193
			[Token(Token = "0x4000891")]
			UNKNOWN_STATE,
			// Token: 0x04000892 RID: 2194
			[Token(Token = "0x4000892")]
			DEFAULT,
			// Token: 0x04000893 RID: 2195
			[Token(Token = "0x4000893")]
			EMPTY,
			// Token: 0x04000894 RID: 2196
			[Token(Token = "0x4000894")]
			LEARNING
		}
	}
}
