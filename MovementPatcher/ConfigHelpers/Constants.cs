using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovementPatcher {
	public readonly struct Constants {
		public const float NullFloat = -0.0F;
		public const string FastWalkInterpolationEditorID = "fFastWalkInterpolationBetweenWalkAndRun";
		public const string JogInterpolationEditorID = "fJogInterpolationBetweenWalkAndRun";

		public readonly struct VanillaGameSettings {
			public const float FastWalkInterpolation = 0.15F;
			public const float JogInterpolation = 0.65F;
		}

		public readonly struct DefaultGameSettings {
			public const float FastWalkInterpolation = 0.001F;
			public const float JogInterpolation = 0.999F;
		}
	}
}
