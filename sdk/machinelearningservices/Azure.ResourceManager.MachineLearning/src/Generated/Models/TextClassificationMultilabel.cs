// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.ResourceManager.MachineLearning;

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary>
    /// Text Classification Multilabel task in AutoML NLP vertical.
    /// NLP - Natural Language Processing.
    /// </summary>
    public partial class TextClassificationMultilabel : AutoMLVertical
    {
        /// <summary> Initializes a new instance of <see cref="TextClassificationMultilabel"/>. </summary>
        /// <param name="trainingData"> [Required] Training data input. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="trainingData"/> is null. </exception>
        public TextClassificationMultilabel(MachineLearningTableJobInput trainingData) : base(trainingData)
        {
            if (trainingData == null)
            {
                throw new ArgumentNullException(nameof(trainingData));
            }

            SearchSpace = new ChangeTrackingList<NlpParameterSubspace>();
            TaskType = TaskType.TextClassificationMultilabel;
        }

        /// <summary> Initializes a new instance of <see cref="TextClassificationMultilabel"/>. </summary>
        /// <param name="logVerbosity"> Log verbosity for the job. </param>
        /// <param name="targetColumnName">
        /// Target column name: This is prediction values column.
        /// Also known as label column name in context of classification tasks.
        /// </param>
        /// <param name="taskType"> [Required] Task type for AutoMLJob. </param>
        /// <param name="trainingData"> [Required] Training data input. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="primaryMetric">
        /// Primary metric for Text-Classification-Multilabel task.
        /// Currently only Accuracy is supported as primary metric, hence user need not set it explicitly.
        /// </param>
        /// <param name="featurizationSettings"> Featurization inputs needed for AutoML job. </param>
        /// <param name="fixedParameters"> Model/training parameters that will remain constant throughout training. </param>
        /// <param name="limitSettings"> Execution constraints for AutoMLJob. </param>
        /// <param name="searchSpace"> Search space for sampling different combinations of models and their hyperparameters. </param>
        /// <param name="sweepSettings"> Settings for model sweeping and hyperparameter tuning. </param>
        /// <param name="validationData"> Validation data inputs. </param>
        internal TextClassificationMultilabel(MachineLearningLogVerbosity? logVerbosity, string targetColumnName, TaskType taskType, MachineLearningTableJobInput trainingData, IDictionary<string, BinaryData> serializedAdditionalRawData, ClassificationMultilabelPrimaryMetric? primaryMetric, NlpVerticalFeaturizationSettings featurizationSettings, NlpFixedParameters fixedParameters, NlpVerticalLimitSettings limitSettings, IList<NlpParameterSubspace> searchSpace, NlpSweepSettings sweepSettings, MachineLearningTableJobInput validationData) : base(logVerbosity, targetColumnName, taskType, trainingData, serializedAdditionalRawData)
        {
            PrimaryMetric = primaryMetric;
            FeaturizationSettings = featurizationSettings;
            FixedParameters = fixedParameters;
            LimitSettings = limitSettings;
            SearchSpace = searchSpace;
            SweepSettings = sweepSettings;
            ValidationData = validationData;
            TaskType = taskType;
        }

        /// <summary> Initializes a new instance of <see cref="TextClassificationMultilabel"/> for deserialization. </summary>
        internal TextClassificationMultilabel()
        {
        }

        /// <summary>
        /// Primary metric for Text-Classification-Multilabel task.
        /// Currently only Accuracy is supported as primary metric, hence user need not set it explicitly.
        /// </summary>
        public ClassificationMultilabelPrimaryMetric? PrimaryMetric { get; }
        /// <summary> Featurization inputs needed for AutoML job. </summary>
        internal NlpVerticalFeaturizationSettings FeaturizationSettings { get; set; }
        /// <summary> Dataset language, useful for the text data. </summary>
        public string FeaturizationDatasetLanguage
        {
            get => FeaturizationSettings is null ? default : FeaturizationSettings.DatasetLanguage;
            set
            {
                if (FeaturizationSettings is null)
                    FeaturizationSettings = new NlpVerticalFeaturizationSettings();
                FeaturizationSettings.DatasetLanguage = value;
            }
        }

        /// <summary> Model/training parameters that will remain constant throughout training. </summary>
        public NlpFixedParameters FixedParameters { get; set; }
        /// <summary> Execution constraints for AutoMLJob. </summary>
        public NlpVerticalLimitSettings LimitSettings { get; set; }
        /// <summary> Search space for sampling different combinations of models and their hyperparameters. </summary>
        public IList<NlpParameterSubspace> SearchSpace { get; set; }
        /// <summary> Settings for model sweeping and hyperparameter tuning. </summary>
        public NlpSweepSettings SweepSettings { get; set; }
        /// <summary> Validation data inputs. </summary>
        public MachineLearningTableJobInput ValidationData { get; set; }
    }
}
